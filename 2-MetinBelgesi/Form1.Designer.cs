
namespace _2_MetinBelgesi
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
            this.btnYolSec = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.txtDosyaAdi = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnYolSec
            // 
            this.btnYolSec.Location = new System.Drawing.Point(436, 29);
            this.btnYolSec.Name = "btnYolSec";
            this.btnYolSec.Size = new System.Drawing.Size(75, 30);
            this.btnYolSec.TabIndex = 0;
            this.btnYolSec.Text = "Yol Sec";
            this.btnYolSec.UseVisualStyleBackColor = true;
            this.btnYolSec.Click += new System.EventHandler(this.btnYolSec_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(436, 71);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 30);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "Olustur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dosya Yolu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dosya Adi :";
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(149, 32);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(264, 26);
            this.txtDosyaYolu.TabIndex = 2;
            // 
            // txtDosyaAdi
            // 
            this.txtDosyaAdi.Location = new System.Drawing.Point(149, 68);
            this.txtDosyaAdi.Name = "txtDosyaAdi";
            this.txtDosyaAdi.Size = new System.Drawing.Size(264, 26);
            this.txtDosyaAdi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(537, 118);
            this.Controls.Add(this.txtDosyaAdi);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.btnYolSec);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYolSec;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.TextBox txtDosyaAdi;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

