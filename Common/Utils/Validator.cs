using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utils
{
    public static class Validator
    {
        //simpre: cualquier artibuo o metodo, se debe definir como static

       public static bool IsDecimal(string texto)
        {

            if (string.IsNullOrEmpty(texto))
            {
                return false;
            }

            if(!decimal.TryParse(texto, NumberStyles.Number, CultureInfo.CurrentCulture, out _)) {                
                return false;
            }

            return true;

        }








    }
}
