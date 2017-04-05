using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moq.CalcBusiness
{
    public interface ICalculator
    {
        int Add(int param1, int param2);
        int Subtract(int param1, int param2);
        int Multipy(int param1, int param2);
        int Divide(int param1, int param2);
        int ConvertUSDtoCLP(int unit);
    
      }

    public interface IUSD_CLP_ExchangeRateFeed
    {
        int GetActualUSDValue();
    }


    public class calc : ICalculator
    {
        private IUSD_CLP_ExchangeRateFeed _feed;
        public calc(IUSD_CLP_ExchangeRateFeed  feed)
        {          //constructor
            this._feed = feed;
        }

        public int Add(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Subtract(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Multipy(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Divide(int param1, int param2)
        {
            return param1 / param2;
        }

        public int ConvertUSDtoCLP(int unit)
        {
            return unit * this._feed.GetActualUSDValue();
        }

    }
}
