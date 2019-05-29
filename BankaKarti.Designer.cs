namespace SiparişOtomasyonProje
{
    partial class BankaKarti
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBankNo = new System.Windows.Forms.TextBox();
            this.txtBankSifre = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(123, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kart No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtBankNo
            // 
            this.txtBankNo.Location = new System.Drawing.Point(237, 75);
            this.txtBankNo.Name = "txtBankNo";
            this.txtBankNo.Size = new System.Drawing.Size(239, 26);
            this.txtBankNo.TabIndex = 1;
            // 
            // txtBankSifre
            // 
            this.txtBankSifre.Location = new System.Drawing.Point(237, 130);
            this.txtBankSifre.Name = "txtBankSifre";
            this.txtBankSifre.Size = new System.Drawing.Size(76, 26);
            this.txtBankSifre.TabIndex = 2;
            this.txtBankSifre.UseSystemPasswordChar = true;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(237, 181);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(142, 37);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // BankaKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(630, 271);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtBankSifre);
            this.Controls.Add(this.txtBankNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BankaKarti";
            this.Text = "BankaKarti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBankNo;
        private System.Windows.Forms.TextBox txtBankSifre;
        private System.Windows.Forms.Button btnGonder;
    }
}