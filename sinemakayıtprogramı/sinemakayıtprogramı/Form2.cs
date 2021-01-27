using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sinemakayıtprogramı
{
    public partial class Form2 : Form
    {
        veri v = new veri();
        OleDbDataReader gv;
        int kno ,fiyat=0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kno = 1;
            button1.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            v.baglan();
            gv = v.oku("Select koltuk_no from bilet_tbl,film_tbl where bilet_tbl.film_no=film_tbl.film_no and film_adı='" + comboBox1.Text + "' and tarih =cdate('" + textBox1.Text + "') and saat='" + comboBox2.Text + "' ");
            while(gv.Read() == true)
            {
                if (Convert.ToInt16 (  gv["koltuk_no"]) == 1)
                {
                    button1.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button1.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 2)
                {
                    button2.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button2.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 3)
                {
                    button3.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button3.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 4)
                {
                    button4.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button4.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 5)
                {
                    button5.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button5.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 6)
                {
                    button6.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button6.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 7)
                {
                    button7.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button7.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 8)
                {
                    button8.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button8.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 9)
                {
                    button9.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button9.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 10)
                {
                    button10.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button10.Enabled = false;

                }

                if (Convert.ToInt16(gv["koltuk_no"]) == 11)
                {
                    button11.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button1.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 12)
                {
                    button12.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button12.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 13)
                {
                    button13.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button13.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 14)
                {
                    button14.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button14.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 15)
                {
                    button15.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button15.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 16)
                {
                    button16.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button16.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 17)
                {
                    button17.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button17.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 18)
                {
                    button18.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button18.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 19)
                {
                    button19.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button19.Enabled = false;

                }
                if (Convert.ToInt16(gv["koltuk_no"]) == 20)
                {
                    button20.BackgroundImage = Image.FromFile("..//..//resim/dolu.jpg");
                    button20.Enabled = false;

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            kno = 16;
            button16.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kno = 9;
            button9.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinemaDataSet1.film_tbl' table. You can move, or remove it, as needed.
            this.film_tblTableAdapter.Fill(this.sinemaDataSet1.film_tbl);
            textBox1.Text = DateTime.Now.Date.ToShortDateString();
            this.Text = "BİLET SATIŞ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kno = 2;
            button2.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            kno = 3;

            button3.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kno = 4;
            button4.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kno = 5;
            button5.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kno = 7;

            button7.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kno = 6;
            button6.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kno = 8;
            button8.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kno = 10;
            button10.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kno = 11;
            button11.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kno = 12;
            button12.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kno = 13;
            button13.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            kno = 14;
            button14.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            kno = 15;
            button15.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            kno = 17;
            button17.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            kno = 18;
            button18.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            kno = 19;
            button19.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            kno = 20;
            button20.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button1.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button2.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button3.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button4.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button5.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button6.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button7.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button8.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button9.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button10_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button10.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button11_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button11.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button12_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button12.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button13_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button13.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button14_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button14.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button15_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button15.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button16_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button16.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button17_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button17.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button18_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button18.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button19_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button19.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button20_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                button20.BackgroundImage = ActiveForm.BackgroundImage;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                fiyat=25;
            }
            if (radioButton2.Checked == true)
            {
                fiyat = 15;
            }
            
            v.baglan();
            v.komut("insert into bilet_tbl (film_no,koltuk_no,saat,tarih,fiyat) select film_no,"+kno+",'"+comboBox2.Text+"','"+textBox1.Text+"',"+fiyat+" from film_tbl where film_adı='"+comboBox1.Text+"' ");
            v.kapat();
            MessageBox.Show("kayıt yapılmıştır");
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.BackgroundImage = ActiveForm.BackgroundImage;
            button2.BackgroundImage = ActiveForm.BackgroundImage;
            button3.BackgroundImage = ActiveForm.BackgroundImage;
            button4.BackgroundImage = ActiveForm.BackgroundImage;
            button5.BackgroundImage = ActiveForm.BackgroundImage;
            button6.BackgroundImage = ActiveForm.BackgroundImage;
            button7.BackgroundImage = ActiveForm.BackgroundImage;
            button8.BackgroundImage = ActiveForm.BackgroundImage;
            button9.BackgroundImage = ActiveForm.BackgroundImage;
            button10.BackgroundImage = ActiveForm.BackgroundImage;
            button10.BackgroundImage = ActiveForm.BackgroundImage;
            button11.BackgroundImage = ActiveForm.BackgroundImage;
            button12.BackgroundImage = ActiveForm.BackgroundImage;
            button13.BackgroundImage = ActiveForm.BackgroundImage;
            button14.BackgroundImage = ActiveForm.BackgroundImage;
            button15.BackgroundImage = ActiveForm.BackgroundImage;
            button16.BackgroundImage = ActiveForm.BackgroundImage;
            button17.BackgroundImage = ActiveForm.BackgroundImage;
            button18.BackgroundImage = ActiveForm.BackgroundImage;
            button19.BackgroundImage = ActiveForm.BackgroundImage;
            button20.BackgroundImage = ActiveForm.BackgroundImage;
          
            
            
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            kno = 3;
            button3.BackgroundImage = Image.FromFile("..//..//resim/tık.jpg");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
