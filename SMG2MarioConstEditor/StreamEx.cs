namespace SMG2PlayerConstEditor;

// I can't remember why I didn't use Hack.io for this...
public static class StreamEx
{
    public static float ReadSingle(this Stream FS) => BitConverter.ToSingle(FS.Read(4), 0);
    public static uint ReadUInt(this Stream FS) => BitConverter.ToUInt32(FS.Read(4), 0);
    public static int ReadInt(this Stream FS) => BitConverter.ToInt32(FS.Read(4), 0);
    public static ushort ReadUShort(this Stream FS) => BitConverter.ToUInt16(FS.Read(2), 0);
    public static short ReadShort(this Stream FS) => BitConverter.ToInt16(FS.Read(2), 0);
    public static byte ReadByte(this Stream FS) => (byte)FS.ReadByte();
    public static sbyte ReadSByte(this Stream FS) => (sbyte)FS.ReadByte();
    public static Color ReadColor(this Stream FS, int Alpha = 0, int Red = 1, int Green = 2, int Blue = 3)
    {
        byte[] bytes = FS.Read(4);
        return Color.FromArgb(bytes[Alpha], bytes[Red], bytes[Green], bytes[Blue]);
    }

    private static byte[] Read(this Stream FS, int count)
    {
        byte[] data = new byte[count];
        FS.Read(data, 0, data.Length);
        return data.Reverse().ToArray();
    }


    public static void WriteSingle(this Stream FS, float value) => Write(FS, BitConverter.GetBytes(value));
    public static void WriteUInt(this Stream FS, uint value) => Write(FS, BitConverter.GetBytes(value));
    public static void WriteInt(this Stream FS, int value) => Write(FS, BitConverter.GetBytes(value));
    public static void WriteUShort(this Stream FS, ushort value) => Write(FS, BitConverter.GetBytes(value));
    public static void WriteShort(this Stream FS, short value) => Write(FS, BitConverter.GetBytes(value));
    public static void WriteByte(this Stream FS, byte value) => FS.WriteByte(value);
    public static void WriteSByte(this Stream FS, sbyte value) => FS.WriteByte((byte)value);
    public static void WriteColor(this Stream FS, Color value, int Alpha = 0, int Red = 1, int Green = 2, int Blue = 3)
    {
        byte[] bytes = new byte[4];
        bytes[Alpha] = value.A;
        bytes[Red] = value.R;
        bytes[Green] = value.G;
        bytes[Blue] = value.B;
        Write(FS, bytes);
    }

    private static void Write(this Stream FS, byte[] data) => FS.Write(data.Reverse().ToArray(), 0, data.Length);
}