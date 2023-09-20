string msgPattern = "| {0,15} |\t {1,5} |\t {2,10} |\t {3,30} |\t {4,30} |";

Console.WriteLine(string.Format(msgPattern, "Type", "Size", "Example", "Min", "Max"));
Console.WriteLine(string.Format(msgPattern, "---", "---", "---", "---", "---"));
Console.WriteLine(string.Format(msgPattern, typeof(byte), sizeof(byte), 10, byte.MinValue, byte.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(sbyte), sizeof(sbyte), 10, sbyte.MinValue, sbyte.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(short), sizeof(short), 10, short.MinValue, short.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(ushort), sizeof(ushort), 10, ushort.MinValue, ushort.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(int), sizeof(int), 10, int.MinValue, int.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(uint), sizeof(uint), 10, uint.MinValue, uint.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(long), sizeof(long), 10, long.MinValue, long.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(ulong), sizeof(ulong), 10, ulong.MinValue, ulong.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(float), sizeof(float), 10, float.MinValue, float.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(double), sizeof(double), 10, double.MinValue, double.MaxValue));
Console.WriteLine(string.Format(msgPattern, typeof(decimal), sizeof(decimal), 10, decimal.MinValue, decimal.MaxValue));