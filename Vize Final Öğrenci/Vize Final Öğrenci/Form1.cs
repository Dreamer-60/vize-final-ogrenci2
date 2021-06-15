using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Final_Öğrenci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  
        {
            listBox1.Items.Clear();
            string[] adsoyad = new string[4];// 0,1,2,3
            double[] vize = new double[4];
            double[] final = new double[4];
            double[] ortalama = new double[4];
        
            adsoyad[1] = textBox1.Text;
            adsoyad[2] = textBox2.Text;
            adsoyad[3] = textBox3.Text;
       
            vize[1] = Convert.ToDouble(textBox4.Text);
            vize[2] = Convert.ToDouble(textBox5.Text);
            vize[3] = Convert.ToDouble(textBox6.Text);

            final[1] = Convert.ToDouble(textBox7.Text);
            final[2] = Convert.ToDouble(textBox8.Text);
            final[3] = Convert.ToDouble(textBox9.Text);

           
            ortalama[1] = vize[1] * 0.4 + final[1] * 0.6;
            ortalama[2] = vize[2] * 0.4 + final[2] * 0.6;
            ortalama[3] = vize[3] * 0.4 + final[3] * 0.6;


            double boskova = 0;
            string bosadsoyad;

            if (ortalama[1]<ortalama[2])
            {
                boskova = ortalama[1];
                ortalama[1] = ortalama[2];
                ortalama[2] = boskova;

                bosadsoyad = adsoyad[1];
                adsoyad[1] = adsoyad[2];
                adsoyad[2] = bosadsoyad;
            }

            if (ortalama[2]<ortalama[3])
            {
                boskova = ortalama[2];
                ortalama[2] = ortalama[3];
                ortalama[3] = boskova;

                bosadsoyad = adsoyad[2];
                adsoyad[2] = adsoyad[3];
                adsoyad[3] = bosadsoyad;
            }
            if (ortalama[1] < ortalama[2])
            {
                boskova = ortalama[1];
                ortalama[1] = ortalama[2];
                ortalama[2] = boskova;

                bosadsoyad = adsoyad[1];
                adsoyad[1] = adsoyad[2];
                adsoyad[2] = bosadsoyad;
            }

            listBox1.Items.Add("Ortalamaya Göre Büyükten Küçüğe Sıralanırsa...");
            listBox1.Items.Add("1." + ortalama[1] + "puanla" + adsoyad[1]);
            listBox1.Items.Add("2." + ortalama[2] + "puanla" + adsoyad[2]);
            listBox1.Items.Add("3." + ortalama[3] + "puanla" + adsoyad[3]);
        }

    }
}
