using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole;

namespace TestProject
{

    [TestClass]
    public class CompressorTests
    {

        private byte[] deltaValues = { 0, 1, 2, 4, 8, 16, 32, 64, 128, 192, 224, 240, 248, 252, 254, 255 };


        [TestMethod]
        public void Can_Compress_2_Bytes()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            var compressor = new Compressor(deltaStrategy);
            var bytes = new byte[] { 32, 64 };

            var (result, originalLength) = compressor.Compress(bytes);

            Assert.AreEqual(32,result[0]);
            Assert.AreEqual(6<<4,result[1]);

        }


        [TestMethod]
        public void Can_Compress_3_Bytes()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            var compressor = new Compressor(deltaStrategy);
            var bytes = new byte[] { 32, 64, 96 };

            var (result, originalLength) = compressor.Compress(bytes);

            Assert.AreEqual(32,result[0]);
            Assert.AreEqual(6<<4|6,result[1]);

        }

        [TestMethod]
        public void Can_Compress_SinWave()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            var compressor = new Compressor(deltaStrategy);
            var bytes = new byte[] { 0,20,41,59,77,91,103,112,118,120,118,112,103,91,77,59,41,20,0,236,215,196,179,165,153,144,138,136,138,144,153,165,179,196,215,236 };

            var (compressedResult,originalLength) = compressor.Compress(bytes);
            Console.WriteLine("Compressed Result");
            Console.WriteLine(string.Join(",", compressedResult.Select(x => x.ToString("X2"))));

            var decompressedResult = compressor.Decompress(compressedResult, originalLength-1);
            Console.WriteLine("Decompressed Result");
            Console.WriteLine(string.Join(",", decompressedResult.Select(x => x.ToString("X2"))));

            Console.WriteLine("Original Data");
            Console.WriteLine(string.Join(",", bytes.Select(x => x.ToString("X2"))));

            var differences = new List<byte>();
            for (int i = 0; i < bytes.Length; i++)
            {
                differences.Add((byte)(bytes[i] - decompressedResult[i]));
            }
            Console.WriteLine("Differences");
            Console.WriteLine(string.Join(",", differences.Select(x => x.ToString("X2"))));

            // Deltas Offsets (initial value = 00)
            // 55,55,55,53,3E,CC,BB,BB,AC,AC,AD,BB,EC,02,34,45,55,50




        }

    }

}
