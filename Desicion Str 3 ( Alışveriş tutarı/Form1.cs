using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desicion_Str_3___Alışveriş_tutarı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kalemadet;
            double tutar;
            kalemadet = Convert.ToInt16(textBox1.Text);
            if (kalemadet >= 0 && kalemadet <= 10)
            {
                tutar = (kalemadet * 10) - (kalemadet * 10 * 0.10);
                textBox2.Text = tutar + "TL";
            }
             if (kalemadet >=10 && kalemadet <= 20)
            {
                tutar = (kalemadet * 10) - (kalemadet * 10 * 0.20);
                textBox2.Text = tutar + "TL";
            }
             if (kalemadet >=20 && kalemadet < 50)
            {
                tutar = (kalemadet * 10) - (kalemadet * 10 * 0.50);
                textBox2.Text = tutar + "TL";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // Satış miktarına göre uygulanan işlemler (ürün kalem)
        // Eğer bir kişi;
        // 0 ile 10 arasında kalem alırsa herbirine % 10 indirim
        // 10 ile 20 arasına % 20 indirim
        // 20 ile 50 arasına % 50 indirim
        // Kalem ücreti: 10 tl
    }
}
