using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sinemakayıtprogramı
{
    public partial class Form3 : Form
    {
        veri v = new veri();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "FİLM KAYIT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v.baglan();
            v.komut("insert into film_tbl (film_adı) values ('"+textBox1.Text+"') ");
            v.kapat();
            MessageBox.Show("kayıt yapılmıştır");
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
        }
    }

