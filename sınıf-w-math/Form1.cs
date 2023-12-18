using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıf_w_math
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

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToSingle(txtSayı.Text);//sayısal olarak texti çevirdik 

            //işlemler
            double sayiMutlak = Math.Abs(sayi);
            double sayiUs = Math.Pow(sayi, 2);
            double sayiKarakok= Math.Sqrt(sayi);
            double sayiYukariYuvarla = Math.Ceiling(sayi);
            double sayiAsagiYuvarla = Math.Floor(sayi);
            double  sayiYuvarla=Math.Round(sayi);
            //  round,floor ,Ceil



            //sonuçları yazdır
            lblMutlak.Text = "sayının mutlak değeri:" + sayiMutlak.ToString();
            lblUst.Text = "sayının kare jöku:" + sayiUs.ToString();
            lblKok.Text = "sayının kare kökü:" + sayiKarakok.ToString();
            lblYukarıYuvarla.Text = "sayını yukarı yuvarla:"+sayiYukariYuvarla.ToString();
            lblAsagiYuvarla.Text = "sayı aşağı yuvarla:" + sayiAsagiYuvarla.ToString();
            lblYuvarla.Text = "sayı yuvarla:" + sayiYuvarla.ToString();
        }
    }
}
