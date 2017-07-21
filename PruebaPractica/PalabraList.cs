using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPractica
{
    class PalabraList : List<Palabra>
    {

        private readonly StringComparison _stringComparison;

        public PalabraList(bool caseSensitive)
        {
            _stringComparison = caseSensitive? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
        }
        public PalabraList(string palabras, bool caseSensitive)
        {
            _stringComparison = caseSensitive? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase;
            Agregar(palabras);
        }

        public void Agregar(string palabras)
        {
            foreach (var p in palabras.Split(','))
            {
                string pal = p.Trim();
                if (!pal.Equals(""))
                {
                    Palabra palabra = Find(pa => pa.Nombre.Equals(pal, _stringComparison));
                    if (palabra == null)
                    {
                        palabra = new Palabra(pal);
                        Add(palabra);
                    }
                    else
                    {
                        palabra.Cantidad++;
                    }
                }
            }
            Ordenar();
        }

        public void Ordenar()
        {
            this.Sort(new ConparadorPalabraInverso(_stringComparison));
        }

        public string ListarDeZaA()
        {
            string result = "";
            foreach (var palabra in this)
            {
                result += palabra.Nombre;
                for(int i = 1; i< palabra.Cantidad; i++)
                {
                    result += '*';
                }
                result += "\n";
            }
            return result;
        }
    }
}
