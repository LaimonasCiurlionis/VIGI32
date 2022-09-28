using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08.BookStruct
{
    public struct Saskaita
    {
        public string gavejas;
        public string siuntejas;
        public int moketiViso;
        private string saskaitosNumeris;
        private int number = 1;

        public Saskaita(string gavejas, string siuntejas, int moketiViso)
        {
            this.gavejas = gavejas;
            this.siuntejas = siuntejas;
            this.moketiViso = moketiViso;
            saskaitosNumeris = $"NR_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}_{number++}";
        }

        public string GautiSaskaitosNumeri()
        {
            return saskaitosNumeris;
        }
    }
}
