using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayerr;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPERSONEL ()
        {
            return DALPERSONEL.PersonelListesi();
        }
        public static int LLPERSONELEKLE(EntityPersonel p)
        {
            if (p.AD1!="" && p.Maas > 2000 && p.SOYAD1 != "")
            {
                return DALPERSONEL.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static  bool LLPERSONELSIL (int p)
        {
            if (p>= 1)
            {
                return DALPERSONEL.PersonelSil(p);
            }
            else
            {
                return false;
            }
        }
        public static bool LLPERSONELGUNCELLE(EntityPersonel p)
        {
            if (p.AD1 != "" && p.SOYAD1 != "" && p.SEHIR1 != "" && p.GOREV1 != "" && p.Maas>1000)
            {
                return DALPERSONEL.PersonelGuncelle(p);
            } 
            else
            {
                return false;
            }
        }
    }
}
