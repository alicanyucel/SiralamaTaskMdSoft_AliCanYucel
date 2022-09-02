namespace SıralamaTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rchtxt1 = new System.Windows.Forms.RichTextBox();
            this.btnSayiUret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxt1
            // 
            this.rchtxt1.Location = new System.Drawing.Point(12, 103);
            this.rchtxt1.Name = "rchtxt1";
            this.rchtxt1.Size = new System.Drawing.Size(250, 272);
            this.rchtxt1.TabIndex = 0;
            this.rchtxt1.Text = "";
            this.rchtxt1.TextChanged += new System.EventHandler(this.rchtxt1_TextChanged);
            // 
            // btnSayiUret
            // 
            this.btnSayiUret.Location = new System.Drawing.Point(26, 48);
            this.btnSayiUret.Name = "btnSayiUret";
            this.btnSayiUret.Size = new System.Drawing.Size(167, 23);
            this.btnSayiUret.TabIndex = 1;
            this.btnSayiUret.Text = "Sayıları Üret";
            this.btnSayiUret.UseVisualStyleBackColor = true;
            this.btnSayiUret.Click += new System.EventHandler(this.btnSayiUret_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.btnSayiUret);
            this.Controls.Add(this.rchtxt1);
            this.Name = "Form1";
            this.Text = "Sıralama Algoritması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rchtxt1;
        private Button btnSayiUret;
    }
}