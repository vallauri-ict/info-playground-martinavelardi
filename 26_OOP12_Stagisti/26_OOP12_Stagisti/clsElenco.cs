using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _26_OOP12_Stagisti
{
    sealed class clsElenco  // sealed => questa classe non può essere ereditata
    {
        List<clsAlunno> elenco;

        public clsElenco()
        {
            elenco = new List<clsAlunno>();
        }
        public void inserisci(clsAlunno a)
        {
            elenco.Add(a);
        }
        public void visualizzaDgv(DataGridView dgv)
        {
            dgv.DataSource = typeof(List<>);
            // permette di acquisire i dati da una struttra qualsiasi. viene gestita dalla dgv.
            dgv.DataSource = elenco;
        }
        public int oreAzienda(string nomeA)
        {
            int oreTotAzienda = 0;
            foreach (clsAlunno a in elenco)
            {
                // clsStagista ha le ore
                if (a is clsStagista)   // verifico se a appartiene alla classe stagista
                {
                    clsStagista s = a as clsStagista;   // converto un oggetto
                    if (s.Azienda == nomeA)
                    {
                        oreTotAzienda += Convert.ToInt32(s.Ore);
                    }
                }
            }
            return oreTotAzienda;
        }
        public void cancella()
        {
            if (elenco.Count == 0)
            {
                throw new Exception("Impossibile eseguire, lista vuota");
            }
            else
            {
                elenco.RemoveAt(elenco.Count - 1);
            }
        }
        public void cancella(int pos)   // cancella un elemento da una posizione
        {
            pos--;
            // verifico l'esistenza
            if (elenco.Count == 0)
            {
                throw new Exception("Impossibile eseguire, lista vuota");
            }
            else if (pos < 0 || pos > elenco.Count - 1)
            {
                throw new Exception("Impossibile cancellare, posizione non valida.");
            }
            else
            {
                elenco.RemoveAt(pos);
            }
        }
    }
}
