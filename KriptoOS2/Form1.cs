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
        public string initVector;

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
            initVector = Convert.ToBase64String(tDESprov.IV);
            //key = tDESprov.Key;
            //initVector = tDESprov.IV;

            File.WriteAllText(@"D:\KriptoOS2\Files\kljuc.txt", key.ToString());
            File.WriteAllText(@"D:\KriptoOS2\Files\inic_vektor.txt", initVector.ToString());

            txtKljuc.Text = key.ToString(); 
        }

        private void BtnKripitiraj_Click(object sender, EventArgs e)
        {

            TripleDESCryptoServiceProvider tDESalg = new TripleDESCryptoServiceProvider();

            string tekst = File.ReadAllText(@"D:\KriptoOS2\Files\cisti_text.txt");
            byte[] kriptirano;

            ICryptoTransform tDESencrypt = tDESalg.CreateEncryptor();

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, tDESencrypt, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(cistiTekst);
                    }

                    kriptirano = msEncrypt.ToArray();
                }
            }

            File.WriteAllText(@"D:\KriptoOS2\Files\kriptirani_text.txt", Convert.ToBase64String(kriptirano));
            txtKriptirani.Text = Convert.ToBase64String(kriptirano);
        }

        private void btnDekriptiraj_Click(object sender, EventArgs e)
        {
            TripleDESCryptoServiceProvider tDESalg = new TripleDESCryptoServiceProvider();
            string dekripitrano =null;
            string kriptiranaPoruka = File.ReadAllText(@"D:\KriptoOS2\Files\kriptirani_text.txt");
            byte[] buffer = Convert.FromBase64String(kriptiranaPoruka);

            string kljuc = File.ReadAllText(@"D:\KriptoOS2\Files\kljuc.txt");


            //tDESalg.Key = Convert.FromBase64String(key);
            //tDESalg.IV = Convert.FromBase64String(key);


            ICryptoTransform tDESdecrypt = tDESalg.CreateDecryptor();

            using (MemoryStream msEncrypt = new MemoryStream(buffer))
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, tDESdecrypt, CryptoStreamMode.Read))
                {
                    using (StreamReader swDecrypt = new StreamReader(csEncrypt))
                    {
                        dekripitrano = swDecrypt.ReadToEnd();
                    }

                }
            }

            File.WriteAllText(@"D:\KriptoOS2\Files\dekriptirani_text.txt", dekripitrano);
            txtDekriptirani.Text = dekripitrano;



        }
    }
}
