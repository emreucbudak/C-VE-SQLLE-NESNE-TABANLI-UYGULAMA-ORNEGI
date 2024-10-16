using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr
{
    public class EntityPersonel
    {
        private int id;
        private string AD;
        private string SOYAD;
        private string SEHIR;
        private string GOREV;
        private int maas;

        public int Id { get => id; set => id = value; }
        public string AD1 { get => AD; set => AD = value; }
        public string SOYAD1 { get => SOYAD; set => SOYAD = value; }
        public string SEHIR1 { get => SEHIR; set => SEHIR = value; }
        public string GOREV1 { get => GOREV; set => GOREV = value; }
        public int Maas { get => maas; set => maas = value; }
    }
}
