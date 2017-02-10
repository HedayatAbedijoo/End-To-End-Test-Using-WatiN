using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace UITestingFlow
{
    public static class Helper
    {       
        public static string NormalizeURL(string parameter)
        {
            StringBuilder result = new StringBuilder(parameter);
            result = result.Replace("!", "%21");
            result = result.Replace("\"", "%22");
            result = result.Replace("#", "%23");
            result = result.Replace("$", "%24");
            result = result.Replace("&", "%26");
            result = result.Replace("'", "%27");
            result = result.Replace("(", "%28");
            result = result.Replace(")", "%29");
            result = result.Replace("*", "%2A");
            result = result.Replace("+", "%2B");
            result = result.Replace(",", "%2C");
            result = result.Replace("/", "%2F");
            result = result.Replace(" || ", "&");
            result = result.Replace(" ", "%20");
            return result.ToString();
        }
    }
}
