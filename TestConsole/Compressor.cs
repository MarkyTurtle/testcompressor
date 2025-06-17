using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Compressor
    {

        IDeltaStrategy _deltaStrategy;

        public Compressor(IDeltaStrategy deltaStrategy)
        {
            _deltaStrategy = deltaStrategy;
        }


        public byte[] Compress(byte[] data)
        {
            // data must contain at least 2 bytes

            List<byte> compressedBytes = new List<byte>();
            compressedBytes.Add(data[0]);
            byte previousByte = data[0];

            for (int i = 1; i < data.Length; i+=2)
            {
                int temp;
                byte deltaIndex, deltaValue;
                byte compressedDelta;

                (deltaIndex, deltaValue) = _deltaStrategy.QuantiseDeltaToIndex(previousByte, data[i]);

                // update previous byte value as an approximation based on the delta value.
                previousByte = (byte)(previousByte + deltaValue);

                // store delta index
                compressedDelta = (byte)(deltaIndex << 4);

                if (i < data.Length-1)
                {
                    (deltaIndex, deltaValue) = _deltaStrategy.QuantiseDeltaToIndex(previousByte, data[i+1]);

                    // clamp value to min,max of sbyte value
                    temp = (sbyte)previousByte + (sbyte)deltaValue;
                    previousByte = (byte)Math.Clamp(temp, -128, 127);

                    // store delta index
                    compressedDelta = (byte)(compressedDelta | deltaIndex);
                }

                compressedBytes.Add(compressedDelta);

            }

            return compressedBytes.ToArray();

        }




    }
}
