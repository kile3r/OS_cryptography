using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace KriptoOS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string cistiTekst;
        public string key;

        private void btnUcitajText_Click(object sender, EventArgs e)
        {
            txtCisti.Text = System.IO.File.ReadAllText(@"D:\KriptoOS2\Files\cisti_text.txt");
            cistiTekst = txtCisti.Text;
            //ucitava se čisti tekst iz dat
        }

        private void btnGenerirajKljuc_Click(object sender, EventArgs e)
        {
            TripleDESCryptoServiceProvider tDESprov = new TripleDESCryptoServiceProvider();
            //kljuc mora bit blok bitova pa se konvertira u base64
            key = Convert.ToBase64String(tDESprov.Key);

            File.WriteAllText(@"D:\KriptoOS2\Files\kljuc.txt", key);

            txtKljuc.Text = key.ToString();
            
        }
    }
}
