using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h=0, t=0;//h(yükseklik) t(saniye)
            while(h>=0)//yükseklik 0 dan küçük olana kadar çalış
            {
                h=3+(10 * t) - (t * t);//yükseklik sayı1(10*saniye) sayı2(saniye*saniye) (sayı1-sayı2) +3 = yükseklik
                listBox1.Items.Add(t+".saniye: "+h);//saniyeyi yazdır onun yanına saniye yaz ve karşısına yüksekliği yaz
                t++;//her seferınde sanıyeyı arttır.
            }
        }
    }
}
