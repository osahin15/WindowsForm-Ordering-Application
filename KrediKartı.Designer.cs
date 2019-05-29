namespace SiparişOtomasyonProje
{
    partial class KrediKartı
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtKrediNo = new System.Windows.Forms.TextBox();
            this.txtKrediSifre = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.comboTip = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTime = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(142, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kart No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Son Kullanım Tarihi:";
            // 
            // txtKrediNo
            // 
            this.txtKrediNo.Location = new System.Drawing.Point(294, 57);
            this.txtKrediNo.Name = "txtKrediNo";
            this.txtKrediNo.Size = new System.Drawing.Size(219, 26);
            this.txtKrediNo.TabIndex = 1;
            // 
            // txtKrediSifre
            // 
            this.txtKrediSifre.Location = new System.Drawing.Point(294, 103);
            this.txtKrediSifre.MaxLength = 4;
            this.txtKrediSifre.Name = "txtKrediSifre";
            this.txtKrediSifre.Size = new System.Drawing.Size(65, 26);
            this.txtKrediSifre.TabIndex = 2;
            this.txtKrediSifre.UseSystemPasswordChar = true;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(294, 223);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(172, 66);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // comboTip
            // 
            this.comboTip.FormattingEnabled = true;
            this.comboTip.Items.AddRange(new object[] {
            "MasterCard",
            "Visa"});
            this.comboTip.Location = new System.Drawing.Point(294, 136);
            this.comboTip.Name = "comboTip";
            this.comboTip.Size = new System.Drawing.Size(163, 28);
            this.comboTip.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(147, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tip:";
            // 
            // mskTime
            // 
            this.mskTime.Location = new System.Drawing.Point(294, 178);
            this.mskTime.Mask = "00/00";
            this.mskTime.Name = "mskTime";
            this.mskTime.Size = new System.Drawing.Size(163, 26);
            this.mskTime.TabIndex = 7;
            this.mskTime.ValidatingType = typeof(System.DateTime);
            // 
            // KrediKartı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(674, 301);
            this.Controls.Add(this.mskTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTip);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtKrediSifre);
            this.Controls.Add(this.txtKrediNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KrediKartı";
            this.Text = "KrediKartı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKrediNo;
        private System.Windows.Forms.TextBox txtKrediSifre;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.ComboBox comboTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTime;
    }
}