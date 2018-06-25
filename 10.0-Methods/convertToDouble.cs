using System;
using System.Net.Http.Headers;

namespace Calculate
{
    public class convertToDouble
    {
        public static double Convert(string input)
        {
            double convertedNum;
            try
            {
                if (!double.TryParse(input, out convertedNum))
                {
                    throw new InvalidCastException("The number entered is not numeric");
                }
            }
            catch (Exception e)
            {
                throw new Exception("",e);
            }

            return convertedNum;
        }
        
    }
}