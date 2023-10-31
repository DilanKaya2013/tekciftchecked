using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplam = 0;


            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);


            for (int i = sayi1;i<=sayi2;i++)
            {
                if (chkTek.Checked==true && chkCift.Checked==false)
                {
                    if (i % 2 == 1)
                    {
                        toplam += i;
                    }
                }
                else if (chkCift.Checked==true && chkTek.Checked==false) 
                {
                    if (i % 2 == 0)
                    {
                        toplam += i;
                    }
                }
                else if(chkTek.Checked==true &&chkCift.Checked==true) 
                {
                    toplam += i;
                }
                else
                {
                    toplam = 0;
                }

            }

            txtToplam.Text = toplam.ToString();



        }
    }
}
