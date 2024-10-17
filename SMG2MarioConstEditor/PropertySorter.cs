using System.ComponentModel;

namespace OrderedPropertyGrid;

[AttributeUsage(AttributeTargets.Property)]
public class OrderAttribute(int Order) : Attribute
{
    public int Order { get; set; } = Order;
}

public class OrderedCategoryAttribute(string category, ushort Order) : CategoryAttribute(category.PadLeft(category.Length + (MaxCategories - Order), NonPrintableChar))
{
    private const char NonPrintableChar = '\t';
    private const ushort MaxCategories = 100;
}

public class PropertySorter : ExpandableObjectConverter
{
    public override bool GetPropertiesSupported(ITypeDescriptorContext? context) => true;

    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext? context, object? value, Attribute[]? attributes)
    {
        SortedSet<(int Order, string PropertyName)> SortedProperties = [];
        if (value is null) //This should never happen...
            return new PropertyDescriptorCollection(null, true); //Thanks .NET foundation

        var PropertyDescriptorCollection = TypeDescriptor.GetProperties(value, attributes);

        foreach (PropertyDescriptor PropertyDescriptor in PropertyDescriptorCollection)
        {
            if (PropertyDescriptor.Attributes[typeof(OrderAttribute)] is OrderAttribute oa)
                SortedProperties.Add((oa.Order, PropertyDescriptor.Name));
            else
                SortedProperties.Add((0, PropertyDescriptor.Name));
        }

        return PropertyDescriptorCollection.Sort(SortedProperties.Select(x => x.PropertyName).ToArray());
    }
}