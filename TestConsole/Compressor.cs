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


        public byte[] Decompress(byte[] data, int numberOfDeltas)
        {
            List<byte> decompressedBytes = new List<byte>();

            byte accumulatedValue = data[0];
            decompressedBytes.Add(accumulatedValue);
            int deltaCount = 0;
            for (int i = 1; i < data.Length; i++)
            {
                byte deltaIdx;
                byte deltas = data[i];

                deltaIdx = (byte)((deltas & 0xf0) >> 4);
                accumulatedValue = (byte)(accumulatedValue + _deltaStrategy.DeltaValue(deltaIdx));
                decompressedBytes.Add(accumulatedValue);
                deltaCount++;

                if (deltaCount < numberOfDeltas-1)
                {
                    deltaIdx = (byte)(deltas & 0x0f);
                    accumulatedValue = (byte)(accumulatedValue + _deltaStrategy.DeltaValue(deltaIdx));
                    decompressedBytes.Add(accumulatedValue);
                    deltaCount++;
                }
            }

            return decompressedBytes.ToArray();

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Compressed byte array, original data length</returns>
        public (byte[],int) Compress(byte[] data)
        {
            // data must contain at least 2 bytes

            List<byte> compressedBytes = new List<byte>();
            compressedBytes.Add(data[0]);
            byte previousByte = data[0];

            for (int i = 1; i < data.Length; i += 2)
            {
                int temp;
                byte deltaIndex, deltaValue;
                byte compressedDelta;

                (deltaIndex, deltaValue) = _deltaStrategy.QuantiseDeltaToIndex(previousByte, data[i]);

                // update previous byte value as an approximation based on the delta value.
                previousByte = (byte)(previousByte + deltaValue);

                // store delta index
                compressedDelta = (byte)(deltaIndex << 4);

                if (i < data.Length - 1)
                {
                    (deltaIndex, deltaValue) = _deltaStrategy.QuantiseDeltaToIndex(previousByte, data[i + 1]);

                    // clamp value to min,max of sbyte value
                    temp = (sbyte)previousByte + (sbyte)deltaValue;
                    previousByte = (byte)Math.Clamp(temp, -128, 127);

                    // store delta index
                    compressedDelta = (byte)(compressedDelta | deltaIndex);
                }

                compressedBytes.Add(compressedDelta);

            }

            return (compressedBytes.ToArray(), data.Length);

        }




    }
}
