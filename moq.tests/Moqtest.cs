using System;
using NUnit.Framework;
using Moq;
using moq.CalcBusiness;
  

namespace moq.tests
{
    [TestFixture]
    public class Moqtest 
    {
        
        public IUSD_CLP_ExchangeRateFeed prvActualUSDValue()
        {
            var mockIUSD_CLP_ExchangeRateFeed = new Mock<IUSD_CLP_ExchangeRateFeed>();  
            mockIUSD_CLP_ExchangeRateFeed.Setup(m => m.GetActualUSDValue()).Returns(1000);
            var objvalue = mockIUSD_CLP_ExchangeRateFeed.Object;
            return objvalue;
        }

        [Test(Description ="Divide 9 by 3 ; expected result is 3")]
        public void TC1_Divide9by3() {
            IUSD_CLP_ExchangeRateFeed feed = this.prvActualUSDValue();
            ICalculator calc1 = new calc(feed);
            int res = calc1.Divide(9, 3);
            Assert.AreEqual(3, res);
            
        }

        [Test(Description = "Divide 9 by 0 ; dividebyzeroexception")]
          public void TC1_Divide9by0()
        {
            IUSD_CLP_ExchangeRateFeed feed = this.prvActualUSDValue();
            ICalculator calc1 = new calc(feed);

            Assert.That(() => calc1.Divide(9, 0), Throws.TypeOf<DivideByZeroException>());   

        }


    }
}
