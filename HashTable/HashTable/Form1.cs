using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Tablo hashtable;

        public void btn_ekle_Click(object sender, EventArgs e)
        {
           MessageBox.Show(hashtable.Ekle(Convert.ToInt32(keytext.Text), nametext.Text));
        }

        public void btn_sil_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hashtable.Sil(Convert.ToInt32(keytext.Text)));
        }

        public void sizebutton_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numeric.Value);
            hashtable = new Tablo(x);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
