namespace SiparişOtomasyonProje
{
    partial class MusteriGirisi
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
            this.btnMusteriGrs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMusteriGrs = new System.Windows.Forms.TextBox();
            this.txtMusteriSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMusteriGrs
            // 
            this.btnMusteriGrs.Location = new System.Drawing.Point(193, 192);
            this.btnMusteriGrs.Name = "btnMusteriGrs";
            this.btnMusteriGrs.Size = new System.Drawing.Size(131, 24);
            this.btnMusteriGrs.TabIndex = 0;
            this.btnMusteriGrs.Text = "Giriş";
            this.btnMusteriGrs.UseVisualStyleBackColor = true;
            this.btnMusteriGrs.Click += new System.EventHandler(this.btnMusteriGrs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(83, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // txtMusteriGrs
            // 
            this.txtMusteriGrs.Location = new System.Drawing.Point(193, 89);
            this.txtMusteriGrs.Name = "txtMusteriGrs";
            this.txtMusteriGrs.Size = new System.Drawing.Size(131, 22);
            this.txtMusteriGrs.TabIndex = 3;
            // 
            // txtMusteriSifre
            // 
            this.txtMusteriSifre.Location = new System.Drawing.Point(193, 139);
            this.txtMusteriSifre.Name = "txtMusteriSifre";
            this.txtMusteriSifre.Size = new System.Drawing.Size(131, 22);
            this.txtMusteriSifre.TabIndex = 4;
            this.txtMusteriSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(29, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parola veya Kullanıcı adı yanlış!!";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MusteriGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriSifre);
            this.Controls.Add(this.txtMusteriGrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMusteriGrs);
            this.Name = "MusteriGirisi";
            this.Text = "Müşteri Giriş";
            this.Load += new System.EventHandler(this.MusteriGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriGrs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMusteriGrs;
        private System.Windows.Forms.TextBox txtMusteriSifre;
        private System.Windows.Forms.Label label3;
    }
}