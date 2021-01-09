using System;
using System.Globalization;
using System.IO;
using System.Net;

namespace InterestCalculatorApi.Services
{
    public class InterestCalculatorService : IInterestCalculatorService
    {
        public double GetInterestRate()
        {
            string url = "https://localhost:5001/taxajuros";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            string responseString = string.Empty;
            double result;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream)) {
                    responseString = reader.ReadToEnd();
                }
                result = Convert.ToDouble(responseString, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }
    }
}
