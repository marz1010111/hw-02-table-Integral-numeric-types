string msgPattern = "| {0,15} |\t {1,5} |\t {2,10} |\t {3,30} |\t {4,30} |";

Console.WriteLine(string.Format(msgPattern, "Type", "Size", "Example", "Min", "Max"));
Console.WriteLine(string.Format(msgPattern, "---", "---", "---", "---", "---"));
Console.WriteLine(string.Format(msgPattern, typeof(byte), sizeof(byte), 20, byte.MinValue, byte.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(sbyte), sizeof(sbyte), -30, sbyte.MinValue, sbyte.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(short), sizeof(short), 40, short.MinValue, short.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(ushort), sizeof(ushort), 50, ushort.MinValue, ushort.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(int), sizeof(int), -65, int.MinValue, int.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(uint), sizeof(uint), 200, uint.MinValue, uint.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(long), sizeof(long), 6833, long.MinValue, long.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(ulong), sizeof(ulong), 67204, ulong.MinValue, ulong.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(float), sizeof(float), 134.45E-2f, float.MinValue, float.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(double), sizeof(double), 78.65, double.MinValue, double.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(decimal), sizeof(decimal), 1005.8M, decimal.MinValue, decimal.MaxValue));