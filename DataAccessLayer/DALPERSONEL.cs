using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayerr;

namespace DataAccessLayer
{
    public class DALPERSONEL
    {
        public static List<EntityPersonel> PersonelListesi ()
        {
            List<EntityPersonel> personel = new List<EntityPersonel> ();
            SqlCommand komut = new SqlCommand ("Select * from TBLBILGI",Baglanti.conn);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open ();
            }
            SqlDataReader reader = komut.ExecuteReader ();
            while (reader.Read())
            {
                EntityPersonel ent = new EntityPersonel ();
                ent.Id = int.Parse(reader["ID"].ToString());
                ent.AD1 = reader["AD"].ToString();
                ent.SOYAD1 = reader["SOYAD"].ToString ();
                ent.GOREV1 = reader["GOREV"].ToString();
                ent.SEHIR1 = reader["SEHIR"].ToString() ;
                ent.Maas = int.Parse(reader["MAAS"].ToString());
                personel.Add (ent);
            }
            reader.Close ();
            return personel;


        }
        public static int PersonelEkle (EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand("insert into TBLBILGI (AD,SOYAD,GOREV,SEHIR,MAAS) VALUES (@p1,@p2,@p3,@p4,@p5)",Baglanti.conn);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open ();
            }
            komut.Parameters.AddWithValue("@p1", p.AD1);
            komut.Parameters.AddWithValue("@p2", p.SOYAD1);
            komut.Parameters.AddWithValue("@p3", p.GOREV1);
            komut.Parameters.AddWithValue("@p4", p.SEHIR1);
            komut.Parameters.AddWithValue("@p5", p.Maas);
            return komut.ExecuteNonQuery ();

        }
        public static bool PersonelSil (int p )
        {
            SqlCommand komutsil = new SqlCommand("Delete from TBLBILGI where ID = @k1", Baglanti.conn);
            if (komutsil.Connection.State != System.Data.ConnectionState.Open)
            {
                komutsil.Connection.Open ();
            }
            komutsil.Parameters.AddWithValue("@k1",p);
            return komutsil.ExecuteNonQuery() > 0;
        }
        public static bool PersonelGuncelle(EntityPersonel p)
        {
            SqlCommand komuts = new SqlCommand("Update TBLBILGI set AD =@a1,SOYAD = @a2 , GOREV = @a3, SEHIR = @a4, MAAS = @a5 where ID = @a6",Baglanti.conn);
            komuts.Parameters.AddWithValue("@a1", p.AD1);
            komuts.Parameters.AddWithValue("@a2", p.SOYAD1);
            komuts.Parameters.AddWithValue("@a3", p.GOREV1);
            komuts.Parameters.AddWithValue("@a4", p.SEHIR1);
            komuts.Parameters.AddWithValue("@a5", p.Maas);
            komuts.Parameters.AddWithValue("@a6", p.Id);
            return komuts.ExecuteNonQuery () > 0;
        }
    }
}
