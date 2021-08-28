
namespace Encapsulation
{
    partial class Form2
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
            this.txtPozisyon = new System.Windows.Forms.Label();
            this.txtYas = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPozisyon
            // 
            this.txtPozisyon.AutoSize = true;
            this.txtPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPozisyon.Location = new System.Drawing.Point(114, 280);
            this.txtPozisyon.Name = "txtPozisyon";
            this.txtPozisyon.Size = new System.Drawing.Size(114, 13);
            this.txtPozisyon.TabIndex = 13;
            this.txtPozisyon.Text = "Personel  Pozisyon";
            // 
            // txtYas
            // 
            this.txtYas.AutoSize = true;
            this.txtYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYas.Location = new System.Drawing.Point(114, 197);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(85, 13);
            this.txtYas.TabIndex = 12;
            this.txtYas.Text = "Personel  Yaş";
            // 
            // txtAd
            // 
            this.txtAd.AutoSize = true;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(114, 126);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(75, 13);
            this.txtAd.TabIndex = 11;
            this.txtAd.Text = "Personel Ad";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.AutoSize = true;
            this.txtPersonelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelID.Location = new System.Drawing.Point(114, 56);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(69, 13);
            this.txtPersonelID.TabIndex = 10;
            this.txtPersonelID.Text = "PersonelID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPozisyon);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtPersonelID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPozisyon;
        private System.Windows.Forms.Label txtYas;
        private System.Windows.Forms.Label txtAd;
        private System.Windows.Forms.Label txtPersonelID;
    }
}