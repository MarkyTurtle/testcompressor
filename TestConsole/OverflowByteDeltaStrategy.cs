using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class OverflowByteDeltaStrategy : IDeltaStrategy
    {

        private byte[] _deltaValues = { 0, 1, 2, 4, 8, 16, 32, 64, 128, 192, 224, 240, 248, 252, 254, 255 };

        public OverflowByteDeltaStrategy(byte[] deltaValues)
        {
            _deltaValues = deltaValues;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="previousValue"></param>
        /// <param name="nextValue"></param>
        /// <returns>(byte)deltaIndex, (byte)deltaValue</returns>
        public (byte,byte) QuantiseDeltaToIndex(byte previousValue, byte nextValue)
        {
            int deltaIndex = 15;
            int deltaDistance = 256;

            for (int i = 0; i < _deltaValues.Length; i++)
            {
                byte testApproximation = (byte)(previousValue + _deltaValues[i]);
                byte testDeltaDistance = (byte)(nextValue - testApproximation);
                if (testDeltaDistance < deltaDistance)
                {
                    deltaDistance = testDeltaDistance;
                    deltaIndex = i;
                }
            }

            return ((byte)deltaIndex,_deltaValues[deltaIndex]);

        }

    }

}
