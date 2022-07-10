namespace HashTable
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
            this.keytext = new System.Windows.Forms.TextBox();
            this.lbl_key = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.name_key = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.Label();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.sizebutton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // keytext
            // 
            this.keytext.Location = new System.Drawing.Point(32, 182);
            this.keytext.Multiline = true;
            this.keytext.Name = "keytext";
            this.keytext.Size = new System.Drawing.Size(227, 24);
            this.keytext.TabIndex = 0;
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Location = new System.Drawing.Point(29, 163);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(75, 16);
            this.lbl_key.TabIndex = 1;
            this.lbl_key.Text = "KEY GİRİN:";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(32, 265);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(227, 67);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "HASH-TABLE\'A EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(295, 265);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(227, 67);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "HASH-TABLE\'DAN SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // name_key
            // 
            this.name_key.AutoSize = true;
            this.name_key.Location = new System.Drawing.Point(292, 163);
            this.name_key.Name = "name_key";
            this.name_key.Size = new System.Drawing.Size(88, 16);
            this.name_key.TabIndex = 4;
            this.name_key.Text = "NAME GİRİN:";
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(295, 182);
            this.nametext.Multiline = true;
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(227, 24);
            this.nametext.TabIndex = 5;
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(12, 9);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(197, 16);
            this.size.TabIndex = 6;
            this.size.Text = "HASHTABLE SIZE BELİRLEME";
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(164, 52);
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(159, 22);
            this.numeric.TabIndex = 8;
            // 
            // sizebutton
            // 
            this.sizebutton.Location = new System.Drawing.Point(164, 80);
            this.sizebutton.Name = "sizebutton";
            this.sizebutton.Size = new System.Drawing.Size(159, 35);
            this.sizebutton.TabIndex = 9;
            this.sizebutton.Text = "BİTTİ";
            this.sizebutton.UseVisualStyleBackColor = true;
            this.sizebutton.Click += new System.EventHandler(this.sizebutton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 381);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(544, 10);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 381);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.sizebutton);
            this.Controls.Add(this.numeric);
            this.Controls.Add(this.size);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.name_key);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.keytext);
            this.Name = "Form1";
            this.Text = "HashTable";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keytext;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label name_key;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.Button sizebutton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

