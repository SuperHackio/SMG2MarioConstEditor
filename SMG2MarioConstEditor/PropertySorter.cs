using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace OrderedPropertyGrid
{
    [AttributeUsage(AttributeTargets.Property)]
    public class OrderAttribute : Attribute
    {
        public OrderAttribute(int Order) => this.Order = Order;
        public int Order { get; set; }
    }

    public class OrderedCategoryAttribute : CategoryAttribute
    {
        private const char NonPrintableChar = '\t';
        private const ushort MaxCategories = 100;

        public OrderedCategoryAttribute(string category, ushort Order) : base(category.PadLeft(category.Length + (MaxCategories - Order), NonPrintableChar))
        {
        }
    }

    public class PropertySorter : ExpandableObjectConverter
    {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context) => true;

        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            var PropertyDescriptorCollection = TypeDescriptor.GetProperties(value, attributes);
            SortedSet<(int Order, string PropertyName)> SortedProperties = new();

            foreach (PropertyDescriptor PropertyDescriptor in PropertyDescriptorCollection)
            {
                var Attribute = PropertyDescriptor.Attributes[typeof(OrderAttribute)];
                if (Attribute != null)
                    SortedProperties.Add(((Attribute as OrderAttribute).Order, PropertyDescriptor.Name));
                else
                    SortedProperties.Add((0, PropertyDescriptor.Name));
            }

            return PropertyDescriptorCollection.Sort(SortedProperties.Select(x => x.PropertyName).ToArray());
        }
    }
}