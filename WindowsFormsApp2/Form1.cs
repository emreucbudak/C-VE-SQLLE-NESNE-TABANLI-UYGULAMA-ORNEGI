using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayerr;
using LogicLayer;
using DataAccessLayer;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> list = LogicPersonel.LLPERSONEL();
            dataGridView1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.AD1 = textBox2.Text;
            ent.SOYAD1 = textBox3.Text;
            ent.GOREV1 = textBox4.Text;
            ent.SEHIR1 = textBox5.Text;
            ent.Maas = int.Parse(textBox6.Text);
            LogicPersonel.LLPERSONELEKLE(ent);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            LogicPersonel.LLPERSONELSIL(a);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = int.Parse(textBox1.Text);
            ent.AD1 = textBox2.Text;
            ent.SOYAD1 = textBox3.Text;
            ent.GOREV1 = textBox4.Text;
            ent.SEHIR1 = textBox5.Text;
            ent.Maas = int.Parse(textBox6.Text);
            LogicPersonel.LLPERSONELGUNCELLE(ent);
        }
    }
}
