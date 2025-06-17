using TestConsole;

namespace TestProject
{
    [TestClass]
    public class ExactDeltaTests
    {

        private byte[] deltaValues = { 0, 1, 2, 4, 8, 16, 32, 64, 128, 192, 224, 240, 248, 252, 254, 255 };

        [TestMethod]
        public void Given_Values_with_delta_of_000__Then__Returns_Delta_Index_00()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, i);
                Assert.AreEqual(0, deltaIndex);
            }

        }

        [TestMethod]
        public void Given_Values_with_delta_of_plus_001__Then__Returns_Delta_Index_01()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 1));
                Assert.AreEqual(1, deltaIndex);
            }
        }



        [TestMethod]
        public void Given_Values_with_delta_of_plus_004__Then__Returns_Delta_Index_03()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 4));
                Assert.AreEqual(3, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_008__Then__Returns_Delta_Index_04()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 8));
                Assert.AreEqual(4, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_016__Then__Returns_Delta_Index_05()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 16));
                Assert.AreEqual(5, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_032__Then__Returns_Delta_Index_06()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 32));
                Assert.AreEqual(6, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_064__Then__Returns_Delta_Index_07()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 64));
                Assert.AreEqual(7, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_128__Then__Returns_Delta_Index_08()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 128));
                Assert.AreEqual(8, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_192__Then__Returns_Delta_Index_09()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 192));
                Assert.AreEqual(9, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_224__Then__Returns_Delta_Index_10()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 224));
                Assert.AreEqual(10, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_240__Then__Returns_Delta_Index_11()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 240));
                Assert.AreEqual(11, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_248__Then__Returns_Delta_Index_12()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 248));
                Assert.AreEqual(12, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_252__Then__Returns_Delta_Index_13()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 252));
                Assert.AreEqual(13, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_254__Then__Returns_Delta_Index_14()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 254));
                Assert.AreEqual(14, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_plus_255__Then__Returns_Delta_Index_15()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i + 255));
                Assert.AreEqual(15, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_255__Then__Returns_Delta_Index_01()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 255));
                Assert.AreEqual(1, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_254__Then__Returns_Delta_Index_02()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 254));
                Assert.AreEqual(2, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_252__Then__Returns_Delta_Index_03()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 252));
                Assert.AreEqual(3, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_248__Then__Returns_Delta_Index_04()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 248));
                Assert.AreEqual(4, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_240__Then__Returns_Delta_Index_05()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 240));
                Assert.AreEqual(5, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_224__Then__Returns_Delta_Index_06()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 224));
                Assert.AreEqual(6, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_192__Then__Returns_Delta_Index_07()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 192));
                Assert.AreEqual(7, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_128__Then__Returns_Delta_Index_08()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 128));
                Assert.AreEqual(8, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_064__Then__Returns_Delta_Index_09()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 64));
                Assert.AreEqual(9, deltaIndex);
            }
        }

        [TestMethod]
        public void Given_Values_with_delta_of_minus_032__Then__Returns_Delta_Index_10()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 32));
                Assert.AreEqual(10, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_016__Then__Returns_Delta_Index_11()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 16));
                Assert.AreEqual(11, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_008__Then__Returns_Delta_Index_12()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 8));
                Assert.AreEqual(12, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_004__Then__Returns_Delta_Index_13()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 4));
                Assert.AreEqual(13, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_002__Then__Returns_Delta_Index_14()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 2));
                Assert.AreEqual(14, deltaIndex);
            }
        }


        [TestMethod]
        public void Given_Values_with_delta_of_minus_001__Then__Returns_Delta_Index_15()
        {
            var deltaStrategy = new OverflowByteDeltaStrategy(deltaValues);
            for (byte i = 0; i < 255; i++)
            {
                var (deltaIndex,deltaValue) = deltaStrategy.QuantiseDeltaToIndex(i, (byte)(i - 1));
                Assert.AreEqual(15, deltaIndex);
            }
        }


    }

}