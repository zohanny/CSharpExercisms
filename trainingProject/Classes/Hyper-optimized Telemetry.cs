using System;

using System.Linq;


namespace trainingProject
{
    public static class TelemetryBuffer
    {
        public static byte[] ToBuffer(long reading)
        {
            byte[] values;
            byte first;

            if (reading < Int32.MinValue)
            {
                first = 256 - 8;
                values = BitConverter.GetBytes((long)reading);
            }
            else if (reading < Int16.MinValue)
            {
                first = 256 - 4;
                values = BitConverter.GetBytes((int)reading);
            }
            else if (reading < UInt16.MinValue)
            {
                first = 256 - 2;
                values = BitConverter.GetBytes((short)reading);
            }
            else if (reading <= UInt16.MaxValue)
            {
                first = 2;
                values = BitConverter.GetBytes((ushort)reading);
            }
            else if (reading <= Int32.MaxValue)
            {
                first = 256 - 4;
                values = BitConverter.GetBytes((int)reading);
            }
            else if (reading <= UInt32.MaxValue)
            {
                values = BitConverter.GetBytes((uint)reading);
                first = 4;
            }
            else
            {
                values = BitConverter.GetBytes((long)reading);
                first = 256 - 8;
            }

            byte[] newValues = new byte[values.Length + 1];
            newValues[0] = first;

            Array.Copy(values, 0, newValues, 1, values.Length);
            return newValues.Concat(new byte[9 - newValues.Count()]).ToArray(); ;

        }
   


        public static long FromBuffer(byte[] buffer)
        {
            long ret;
            if (buffer[0] == 256 - 8 || buffer[0] == 4 || buffer[0] == 2)
                ret = BitConverter.ToInt64(buffer, 1);
            else if (buffer[0] == 256 - 4)
                ret = BitConverter.ToInt32(buffer, 1);
            else if (buffer[0] == 256 - 2)
                ret = BitConverter.ToInt16(buffer, 1);
            else
                ret = 0;
        return ret;
        }
          

    };


}

