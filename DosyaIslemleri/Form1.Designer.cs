
namespace DosyaIslemleri
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
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.btnFileBrowserDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(9, 20);
            this.btnOpenFileDialog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(175, 29);
            this.btnOpenFileDialog.TabIndex = 0;
            this.btnOpenFileDialog.Text = "Open File Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(9, 75);
            this.btnSaveFileDialog.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(175, 29);
            this.btnSaveFileDialog.TabIndex = 0;
            this.btnSaveFileDialog.Text = "Save File Dialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // btnFileBrowserDialog
            // 
            this.btnFileBrowserDialog.Location = new System.Drawing.Point(9, 127);
            this.btnFileBrowserDialog.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileBrowserDialog.Name = "btnFileBrowserDialog";
            this.btnFileBrowserDialog.Size = new System.Drawing.Size(175, 29);
            this.btnFileBrowserDialog.TabIndex = 0;
            this.btnFileBrowserDialog.Text = "Folder Browser Dialog";
            this.btnFileBrowserDialog.UseVisualStyleBackColor = true;
            this.btnFileBrowserDialog.Click += new System.EventHandler(this.btnFileBrowserDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 292);
            this.Controls.Add(this.btnFileBrowserDialog);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.Button btnFileBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

