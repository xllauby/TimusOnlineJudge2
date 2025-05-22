using System;

class Task4
{
    static void Main()
    {
        string senderType = Console.ReadLine();
        ulong v = ulong.Parse(Console.ReadLine());

        byte b0 = (byte)((v >> 24) & 0xFF);
        byte b1 = (byte)((v >> 16) & 0xFF);
        byte b2 = (byte)((v >> 8) & 0xFF);
        byte b3 = (byte)(v & 0xFF);

        ulong result = ((ulong)b3 << 24) | ((ulong)b2 << 16) | ((ulong)b1 << 8) | b0;

        Console.WriteLine(result);
    }
}
