using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Girilen_Sayının__Asal_Olup_Olmadığını_Bulma_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x, y;
        private void button3_Click(object sender, EventArgs e)
        {
           
          
            Random rnd = new Random();
            for (int i = 1; i <=4; i++)
            {
                x = rnd.Next(0, listBox1.Items.Count);
                y = rnd.Next(0, listBox2.Items.Count);
                listBox3.Items.Add(listBox1.Items[x] + "-" + listBox2.Items[y]);
                listBox1.Items.Remove(listBox1.Items[x]);
                listBox2.Items.Remove(listBox2.Items[y]);
             


            }
        }
    }
}



