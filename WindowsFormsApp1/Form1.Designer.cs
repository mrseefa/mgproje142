﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            this.listboxSehirler = new System.Windows.Forms.ListBox();
            this.lblEklenecekehir = new System.Windows.Forms.Label();
            this.txtEklenecekSehir = new System.Windows.Forms.TextBox();
            this.btnSehirEkle = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSehirSil = new System.Windows.Forms.TextBox();
            this.txtSehirAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSehirBul = new System.Windows.Forms.Button();
            this.btnSehirSil = new System.Windows.Forms.Button();
            this.btnSagaAktar = new System.Windows.Forms.Button();
            this.btnSolaAktar = new System.Windows.Forms.Button();
            this.listboxGSehir = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listboxSehirler
            // 
            this.listboxSehirler.AccessibleDescription = "";
            this.listboxSehirler.FormattingEnabled = true;
            this.listboxSehirler.ItemHeight = 16;
            this.listboxSehirler.Location = new System.Drawing.Point(12, 125);
            this.listboxSehirler.Name = "listboxSehirler";
            this.listboxSehirler.Size = new System.Drawing.Size(150, 180);
            this.listboxSehirler.TabIndex = 0;
            this.listboxSehirler.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblEklenecekehir
            // 
            this.lblEklenecekehir.AutoSize = true;
            this.lblEklenecekehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEklenecekehir.Location = new System.Drawing.Point(197, 19);
            this.lblEklenecekehir.Name = "lblEklenecekehir";
            this.lblEklenecekehir.Size = new System.Drawing.Size(119, 18);
            this.lblEklenecekehir.TabIndex = 1;
            this.lblEklenecekehir.Text = "Eklenecek Şehir:";
            this.lblEklenecekehir.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEklenecekSehir
            // 
            this.txtEklenecekSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklenecekSehir.Location = new System.Drawing.Point(332, 19);
            this.txtEklenecekSehir.Name = "txtEklenecekSehir";
            this.txtEklenecekSehir.Size = new System.Drawing.Size(100, 24);
            this.txtEklenecekSehir.TabIndex = 2;
            // 
            // btnSehirEkle
            // 
            this.btnSehirEkle.Location = new System.Drawing.Point(332, 50);
            this.btnSehirEkle.Name = "btnSehirEkle";
            this.btnSehirEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSehirEkle.TabIndex = 3;
            this.btnSehirEkle.Text = "Ekle";
            this.btnSehirEkle.UseVisualStyleBackColor = true;
            this.btnSehirEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.AccessibleName = "";
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Sehirler",
            "Gidilen Sehirler"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(150, 61);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şehir Ara";
            // 
            // txtSehirSil
            // 
            this.txtSehirSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSehirSil.Location = new System.Drawing.Point(121, 388);
            this.txtSehirSil.Name = "txtSehirSil";
            this.txtSehirSil.Size = new System.Drawing.Size(100, 24);
            this.txtSehirSil.TabIndex = 7;
            // 
            // txtSehirAra
            // 
            this.txtSehirAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSehirAra.Location = new System.Drawing.Point(121, 338);
            this.txtSehirAra.Name = "txtSehirAra";
            this.txtSehirAra.Size = new System.Drawing.Size(100, 24);
            this.txtSehirAra.TabIndex = 8;
            this.txtSehirAra.TextChanged += new System.EventHandler(this.txtSehirAra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şehir Sil";
            // 
            // btnSehirBul
            // 
            this.btnSehirBul.Location = new System.Drawing.Point(241, 340);
            this.btnSehirBul.Name = "btnSehirBul";
            this.btnSehirBul.Size = new System.Drawing.Size(75, 23);
            this.btnSehirBul.TabIndex = 10;
            this.btnSehirBul.Text = "Bul";
            this.btnSehirBul.UseVisualStyleBackColor = true;
            this.btnSehirBul.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSehirSil
            // 
            this.btnSehirSil.Location = new System.Drawing.Point(241, 388);
            this.btnSehirSil.Name = "btnSehirSil";
            this.btnSehirSil.Size = new System.Drawing.Size(75, 23);
            this.btnSehirSil.TabIndex = 11;
            this.btnSehirSil.Text = "Sil";
            this.btnSehirSil.UseVisualStyleBackColor = true;
            this.btnSehirSil.Click += new System.EventHandler(this.btnSehirSil_Click);
            // 
            // btnSagaAktar
            // 
            this.btnSagaAktar.Location = new System.Drawing.Point(186, 179);
            this.btnSagaAktar.Name = "btnSagaAktar";
            this.btnSagaAktar.Size = new System.Drawing.Size(75, 23);
            this.btnSagaAktar.TabIndex = 12;
            this.btnSagaAktar.Text = ">>";
            this.btnSagaAktar.UseVisualStyleBackColor = true;
            this.btnSagaAktar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSolaAktar
            // 
            this.btnSolaAktar.Location = new System.Drawing.Point(186, 226);
            this.btnSolaAktar.Name = "btnSolaAktar";
            this.btnSolaAktar.Size = new System.Drawing.Size(75, 23);
            this.btnSolaAktar.TabIndex = 13;
            this.btnSolaAktar.Text = "<<";
            this.btnSolaAktar.UseVisualStyleBackColor = true;
            this.btnSolaAktar.Click += new System.EventHandler(this.btnSolaAktar_Click);
            // 
            // listboxGSehir
            // 
            this.listboxGSehir.FormattingEnabled = true;
            this.listboxGSehir.ItemHeight = 16;
            this.listboxGSehir.Location = new System.Drawing.Point(282, 125);
            this.listboxGSehir.Name = "listboxGSehir";
            this.listboxGSehir.Size = new System.Drawing.Size(150, 180);
            this.listboxGSehir.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "mrSefa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listboxGSehir);
            this.Controls.Add(this.btnSolaAktar);
            this.Controls.Add(this.btnSagaAktar);
            this.Controls.Add(this.btnSehirSil);
            this.Controls.Add(this.btnSehirBul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSehirAra);
            this.Controls.Add(this.txtSehirSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnSehirEkle);
            this.Controls.Add(this.txtEklenecekSehir);
            this.Controls.Add(this.lblEklenecekehir);
            this.Controls.Add(this.listboxSehirler);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listboxSehirler;
        private System.Windows.Forms.Label lblEklenecekehir;
        private System.Windows.Forms.TextBox txtEklenecekSehir;
        private System.Windows.Forms.Button btnSehirEkle;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSehirSil;
        private System.Windows.Forms.TextBox txtSehirAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSehirBul;
        private System.Windows.Forms.Button btnSehirSil;
        private System.Windows.Forms.Button btnSagaAktar;
        private System.Windows.Forms.Button btnSolaAktar;
        private System.Windows.Forms.ListBox listboxGSehir;
        private System.Windows.Forms.Label label3;
    }
}

