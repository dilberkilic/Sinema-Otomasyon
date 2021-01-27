namespace sinemakayıtprogramı
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.filmtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaDataSet1 = new sinemakayıtprogramı.sinemaDataSet1();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.film_tblTableAdapter = new sinemakayıtprogramı.sinemaDataSet1TableAdapters.film_tblTableAdapter();
            this.button22 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filmtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FİLM ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TARİH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SAAT";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.filmtblBindingSource;
            this.comboBox1.DisplayMember = "film_adı";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // filmtblBindingSource
            // 
            this.filmtblBindingSource.DataMember = "film_tbl";
            this.filmtblBindingSource.DataSource = this.sinemaDataSet1;
            // 
            // sinemaDataSet1
            // 
            this.sinemaDataSet1.DataSetName = "sinemaDataSet1";
            this.sinemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "11:00",
            "13:00",
            "15:00",
            "17:00",
            "19:00",
            "21:00"});
            this.comboBox2.Location = new System.Drawing.Point(312, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(58, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(142, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(181, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(48, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(90, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(142, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(181, 260);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 33);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(234, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 33);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button7_MouseDown);
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(276, 260);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 33);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button8_MouseDown);
            // 
            // button9
            // 
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(48, 298);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(33, 33);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button9_MouseDown);
            // 
            // button10
            // 
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Location = new System.Drawing.Point(90, 298);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(33, 33);
            this.button10.TabIndex = 15;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button10_MouseDown);
            // 
            // button11
            // 
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(142, 298);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(33, 33);
            this.button11.TabIndex = 16;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button11_MouseDown);
            // 
            // button12
            // 
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(181, 299);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 33);
            this.button12.TabIndex = 17;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button12_MouseDown);
            // 
            // button13
            // 
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.Location = new System.Drawing.Point(234, 299);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(36, 33);
            this.button13.TabIndex = 18;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button13_MouseDown);
            // 
            // button14
            // 
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(276, 298);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 33);
            this.button14.TabIndex = 19;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button14_MouseDown);
            // 
            // button15
            // 
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.Location = new System.Drawing.Point(48, 337);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(33, 33);
            this.button15.TabIndex = 20;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button15_MouseDown);
            // 
            // button16
            // 
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.Location = new System.Drawing.Point(90, 337);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(33, 33);
            this.button16.TabIndex = 21;
            this.button16.Text = "16";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            this.button16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button16_MouseDown);
            // 
            // button17
            // 
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.Location = new System.Drawing.Point(142, 337);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(33, 33);
            this.button17.TabIndex = 22;
            this.button17.Text = "17";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            this.button17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button17_MouseDown);
            // 
            // button18
            // 
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.Location = new System.Drawing.Point(181, 338);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(36, 33);
            this.button18.TabIndex = 23;
            this.button18.Text = "18";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            this.button18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button18_MouseDown);
            // 
            // button19
            // 
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.Location = new System.Drawing.Point(237, 337);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(33, 33);
            this.button19.TabIndex = 24;
            this.button19.Text = "19";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            this.button19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button19_MouseDown);
            // 
            // button20
            // 
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.Location = new System.Drawing.Point(279, 337);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(33, 33);
            this.button20.TabIndex = 25;
            this.button20.Text = "20";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            this.button20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button20_MouseDown);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button21.Location = new System.Drawing.Point(401, 20);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(95, 37);
            this.button21.TabIndex = 26;
            this.button21.Text = "KONTROL";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::sinemakayıtprogramı.Properties.Resources.LLLL;
            this.pictureBox1.Location = new System.Drawing.Point(12, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "FİYAT";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(401, 127);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 17);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ÖGRENCİ 15";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(401, 104);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "TAM 25";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // film_tblTableAdapter
            // 
            this.film_tblTableAdapter.ClearBeforeFill = true;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button22.Location = new System.Drawing.Point(399, 178);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(83, 37);
            this.button22.TabIndex = 31;
            this.button22.Text = "SATIŞ";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(494, 380);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private sinemaDataSet1 sinemaDataSet1;
        private System.Windows.Forms.BindingSource filmtblBindingSource;
        private sinemaDataSet1TableAdapters.film_tblTableAdapter film_tblTableAdapter;
        private System.Windows.Forms.Button button22;
    }
}