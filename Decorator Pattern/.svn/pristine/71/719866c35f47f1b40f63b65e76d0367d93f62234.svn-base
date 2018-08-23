using System;
using System.IO;

namespace Chapter3
{
    public class LowerCaseInputStream : FileStream
    {
        public LowerCaseInputStream()
            : base(Environment.CurrentDirectory + @"\input.txt", FileMode.Open)
        {
            
        }

        public override int ReadByte()
        {
            int c = base.ReadByte();

            if (c == -1)
            {
                return c;
            }

            char r = char.ToLower((char)c);

            return r;
        }

        public override int Read(byte[] array, int offset, int count)
        {
            int result = base.Read(array, offset, count);

            for (int i = offset; i < offset + result; i++)
            {
                array[i] = (byte)char.ToLower((char) array[i]);
            }

            return result;
        }

    }
}
