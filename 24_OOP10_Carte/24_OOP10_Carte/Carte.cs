using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_OOP10_Carte
{
    class Carte
    {
        private string valore;
        private string seme;

        public string Valore { get => valore; set
            {
                if (valueIsValid(value))
                    valore = value;
                else
                    throw new Exception("Il valore non è corretto");
            }
        }

        private bool valueIsValid(string value)
        {
            bool ok = true;
            value.ToLower();
            if (value!="asso" || value != "2" || value != "3" || value != "4" || value != "5" || value != "6" || value != "7" || value != "8" || value != "9" || value != "10" || value != "fante" || value != "regina" || value != "re")
            {
                ok = false;
            }
            return ok;
        }

        public string Seme { get => seme; set
            {
                if (semeIsValid(value))
                    valore = value;
                else
                    throw new Exception("Il seme non è corretto");
            }
        }

        private bool semeIsValid(string value)
        {
            bool ok = true;
            value.ToLower();
            if (value!="cuori"|| value != "quadri" || value != "fiori" || value != "picche")
            {
                ok = false;
            }
            return ok;
        }
    }
}
