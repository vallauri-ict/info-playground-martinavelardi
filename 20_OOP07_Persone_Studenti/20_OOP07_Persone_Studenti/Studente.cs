using System.Collections.Generic;

namespace _20_OOP07_Persone_Studenti
{
    class Studente : Persona
    {
        List<int> voti = new List<int>();
        public double Media()
        {
            int sommaVoti = 0;
            foreach (var item in voti)
            {
                sommaVoti += item;
            }
            return (double)sommaVoti / voti.Count;
        }
    }
}
