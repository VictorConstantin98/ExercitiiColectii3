using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercitiiColectii3
{
    internal class Librarie
    {
        private string numeLibrarie;
        private Dictionary<Autor, int> dictionarCarti;

        public void setNumeLibrarie(string numeLibrarie)
        {
            this.numeLibrarie = numeLibrarie;
        }

        public Librarie()
        {
            this.numeLibrarie = "";
            dictionarCarti = new Dictionary<Autor, int>();
        }

        public Librarie(string numeLibrarie, Dictionary<Autor, int> dictionarCarti)
        {
            this.numeLibrarie = numeLibrarie;
            this.dictionarCarti = new Dictionary<Autor, int>(dictionarCarti);
        }

        public override string ToString()
        {
            string librarieString = numeLibrarie;
            foreach(KeyValuePair<Autor,int> element in dictionarCarti)
            {
                librarieString = librarieString + "\n" + "Autorul: " + element.Key.getNume() + " Numar carti: " + element.Value;
            }
            return librarieString;
        }

        public void adaugareAutor(Autor autorDeAdaugat)
        {
            dictionarCarti.Add(autorDeAdaugat, 0);
        }

        public void adaugareCarte(Autor autorDeAdaugat2)
        {
            int nrCarti;
            dictionarCarti.TryGetValue(autorDeAdaugat2, out nrCarti);
            if (nrCarti != null)
            {
                dictionarCarti[autorDeAdaugat2] = nrCarti + 1;
            }
        }

        /*public void adaugareCarte(Autor autorDeAdaugat2)
        {
            int nrCarti = 0;
            dictionarCarti[autorDeAdaugat2] = nrCarti + 1;
        }*/

        public void adaugareAutorSiCarte(Autor autorDeAdaugat3)
        {
            dictionarCarti.Add(autorDeAdaugat3, 0);
            int nrCarti;
            dictionarCarti.TryGetValue(autorDeAdaugat3, out nrCarti);
            if(nrCarti != null)
            {
                dictionarCarti[autorDeAdaugat3] = nrCarti + 1;
            }
        }













    }
}
