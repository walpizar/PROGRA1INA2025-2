using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public class Validador
        {
            // Valida que el ID tenga un formato de 9 o 10 dígitos numéricos
            public static bool EsIdValido(string id)
            {
                if (string.IsNullOrEmpty(id))
                {
                    return false;
                }

                // El regex ^\d{9,10}$ busca una cadena que contenga solo dígitos
                // y que tenga una longitud de 9 a 10 caracteres.
                // ^  -> Inicia la búsqueda desde el principio de la cadena.
                // \d -> Coincide con cualquier dígito (0-9).
                // {9,10} -> La longitud debe ser de 9 a 10 dígitos.
                // $  -> Termina la búsqueda al final de la cadena.
                return Regex.IsMatch(id, @"^\d{9,10}$");
            }
        }








    }
}
