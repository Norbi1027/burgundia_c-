using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berek
{
    internal class beker_class
    {
        string Név;
        string Neme;
        string Részleg;
        int Belépés;
        uint Bér;

        public beker_class(string név1, string neme1, string részleg1, int belépés1, uint bér1)
        {
            Név1 = név1;
            Neme1 = neme1;
            Részleg1 = részleg1;
            Belépés1 = belépés1;
            Bér1 = bér1;
        }

        public string Név1 { get => Név; set => Név = value; }
        public string Neme1 { get => Neme; set => Neme = value; }
        public string Részleg1 { get => Részleg; set => Részleg = value; }
        public int Belépés1 { get => Belépés; set => Belépés = value; }
        public uint Bér1 { get => Bér; set => Bér = value; }

        public beker_class(string beolvasottsor)
        {
            string[] strings = beolvasottsor.Split(';');
            Név1 = strings[0];
            Neme1 = strings[1];
            Részleg1 = strings[2];
            Belépés1 = int.Parse(strings[3]);
            Bér1 = uint.Parse(strings[4]);
        }
    }
}
