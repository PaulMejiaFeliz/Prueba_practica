using System;
using System.Collections.Generic;

namespace PruebaPractica
{
    public class ConparadorPalabraInverso : IComparer<Palabra>
    {
        private readonly StringComparison _stringComparison;
        public ConparadorPalabraInverso(StringComparison stringComparison)
        {
            _stringComparison = stringComparison;
        }

        public int Compare(Palabra p1, Palabra p2)
        {
            if (p1 == null && p2 == null)
                return 0;
            if (p1 == null)
                return 1;
            if (p2 == null)
                return -1;
            return -string.Compare(p1.Nombre, p2.Nombre, _stringComparison);
        }
    }
}