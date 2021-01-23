
namespace BilgiYarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoruSayisi = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.pbxYanlis = new System.Windows.Forms.PictureBox();
            this.pbxDogru = new System.Windows.Forms.PictureBox();
            this.lblCevap = new System.Windows.Forms.Label();
            this.lblCevapDogru = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxYanlis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDogru)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(1, 4);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(588, 138);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnA.Location = new System.Drawing.Point(1, 167);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(280, 40);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnB.Location = new System.Drawing.Point(309, 167);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(280, 40);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnC.Location = new System.Drawing.Point(1, 225);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(280, 40);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnD.Location = new System.Drawing.Point(309, 225);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(280, 40);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru Numarasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış";
            // 
            // lblSoruSayisi
            // 
            this.lblSoruSayisi.AutoSize = true;
            this.lblSoruSayisi.Location = new System.Drawing.Point(796, 21);
            this.lblSoruSayisi.Name = "lblSoruSayisi";
            this.lblSoruSayisi.Size = new System.Drawing.Size(19, 24);
            this.lblSoruSayisi.TabIndex = 8;
            this.lblSoruSayisi.Text = "0";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(796, 52);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(19, 24);
            this.lblDogru.TabIndex = 9;
            this.lblDogru.Text = "0";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Location = new System.Drawing.Point(796, 85);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(19, 24);
            this.lblYanlis.TabIndex = 10;
            this.lblYanlis.Text = "0";
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.Yellow;
            this.btnSonraki.Location = new System.Drawing.Point(773, 117);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(100, 36);
            this.btnSonraki.TabIndex = 11;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // pbxYanlis
            // 
            this.pbxYanlis.Image = ((System.Drawing.Image)(resources.GetObject("pbxYanlis.Image")));
            this.pbxYanlis.Location = new System.Drawing.Point(648, 165);
            this.pbxYanlis.Name = "pbxYanlis";
            this.pbxYanlis.Size = new System.Drawing.Size(100, 100);
            this.pbxYanlis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxYanlis.TabIndex = 12;
            this.pbxYanlis.TabStop = false;
            this.pbxYanlis.Visible = false;
            // 
            // pbxDogru
            // 
            this.pbxDogru.Image = ((System.Drawing.Image)(resources.GetObject("pbxDogru.Image")));
            this.pbxDogru.Location = new System.Drawing.Point(773, 165);
            this.pbxDogru.Name = "pbxDogru";
            this.pbxDogru.Size = new System.Drawing.Size(100, 100);
            this.pbxDogru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDogru.TabIndex = 13;
            this.pbxDogru.TabStop = false;
            this.pbxDogru.Visible = false;
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(608, 21);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(58, 24);
            this.lblCevap.TabIndex = 14;
            this.lblCevap.Text = "Cevap";
            this.lblCevap.Visible = false;
            // 
            // lblCevapDogru
            // 
            this.lblCevapDogru.AutoSize = true;
            this.lblCevapDogru.Location = new System.Drawing.Point(608, 52);
            this.lblCevapDogru.Name = "lblCevapDogru";
            this.lblCevapDogru.Size = new System.Drawing.Size(54, 24);
            this.lblCevapDogru.TabIndex = 15;
            this.lblCevapDogru.Text = "Dogru";
            this.lblCevapDogru.Visible = false;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Yellow;
            this.btnBasla.Location = new System.Drawing.Point(648, 117);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(100, 36);
            this.btnBasla.TabIndex = 16;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(891, 278);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblCevapDogru);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.pbxDogru);
            this.Controls.Add(this.pbxYanlis);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.lblSoruSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxYanlis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDogru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoruSayisi;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.PictureBox pbxYanlis;
        private System.Windows.Forms.PictureBox pbxDogru;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label lblCevapDogru;
        private System.Windows.Forms.Button btnBasla;
    }
}

