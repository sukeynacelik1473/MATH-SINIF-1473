namespace sınıf_w_math
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
            this.lblUst = new System.Windows.Forms.Label();
            this.lblKok = new System.Windows.Forms.Label();
            this.lblYuvarla = new System.Windows.Forms.Label();
            this.lblYukarıYuvarla = new System.Windows.Forms.Label();
            this.lblAsagiYuvarla = new System.Windows.Forms.Label();
            this.lblMutlak = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSayı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUst
            // 
            this.lblUst.AutoSize = true;
            this.lblUst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUst.Location = new System.Drawing.Point(245, 52);
            this.lblUst.Name = "lblUst";
            this.lblUst.Size = new System.Drawing.Size(50, 16);
            this.lblUst.TabIndex = 0;
            this.lblUst.Text = "label1";
            // 
            // lblKok
            // 
            this.lblKok.AutoSize = true;
            this.lblKok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKok.Location = new System.Drawing.Point(245, 88);
            this.lblKok.Name = "lblKok";
            this.lblKok.Size = new System.Drawing.Size(50, 16);
            this.lblKok.TabIndex = 1;
            this.lblKok.Text = "label2";
            // 
            // lblYuvarla
            // 
            this.lblYuvarla.AutoSize = true;
            this.lblYuvarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYuvarla.Location = new System.Drawing.Point(245, 121);
            this.lblYuvarla.Name = "lblYuvarla";
            this.lblYuvarla.Size = new System.Drawing.Size(50, 16);
            this.lblYuvarla.TabIndex = 2;
            this.lblYuvarla.Text = "label3";
            // 
            // lblYukarıYuvarla
            // 
            this.lblYukarıYuvarla.AutoSize = true;
            this.lblYukarıYuvarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYukarıYuvarla.Location = new System.Drawing.Point(245, 160);
            this.lblYukarıYuvarla.Name = "lblYukarıYuvarla";
            this.lblYukarıYuvarla.Size = new System.Drawing.Size(50, 16);
            this.lblYukarıYuvarla.TabIndex = 3;
            this.lblYukarıYuvarla.Text = "label4";
            // 
            // lblAsagiYuvarla
            // 
            this.lblAsagiYuvarla.AutoSize = true;
            this.lblAsagiYuvarla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAsagiYuvarla.Location = new System.Drawing.Point(245, 196);
            this.lblAsagiYuvarla.Name = "lblAsagiYuvarla";
            this.lblAsagiYuvarla.Size = new System.Drawing.Size(50, 16);
            this.lblAsagiYuvarla.TabIndex = 4;
            this.lblAsagiYuvarla.Text = "label5";
            // 
            // lblMutlak
            // 
            this.lblMutlak.AutoSize = true;
            this.lblMutlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMutlak.Location = new System.Drawing.Point(245, 232);
            this.lblMutlak.Name = "lblMutlak";
            this.lblMutlak.Size = new System.Drawing.Size(50, 16);
            this.lblMutlak.TabIndex = 5;
            this.lblMutlak.Text = "label6";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(40, 88);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(121, 49);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSayı
            // 
            this.txtSayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayı.Location = new System.Drawing.Point(40, 49);
            this.txtSayı.Name = "txtSayı";
            this.txtSayı.Size = new System.Drawing.Size(121, 22);
            this.txtSayı.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 350);
            this.Controls.Add(this.txtSayı);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblMutlak);
            this.Controls.Add(this.lblAsagiYuvarla);
            this.Controls.Add(this.lblYukarıYuvarla);
            this.Controls.Add(this.lblYuvarla);
            this.Controls.Add(this.lblKok);
            this.Controls.Add(this.lblUst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUst;
        private System.Windows.Forms.Label lblKok;
        private System.Windows.Forms.Label lblYuvarla;
        private System.Windows.Forms.Label lblYukarıYuvarla;
        private System.Windows.Forms.Label lblAsagiYuvarla;
        private System.Windows.Forms.Label lblMutlak;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSayı;
    }
}

