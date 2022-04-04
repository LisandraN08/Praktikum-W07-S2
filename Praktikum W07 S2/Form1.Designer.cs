
namespace Praktikum_W07_S2
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
            this.lblKalimat = new System.Windows.Forms.Label();
            this.lblHuruf = new System.Windows.Forms.Label();
            this.tBoxInputKalimat = new System.Windows.Forms.TextBox();
            this.tBoxInputHuruf = new System.Windows.Forms.TextBox();
            this.lblMenjadi = new System.Windows.Forms.Label();
            this.tBoxTujuanHuruf = new System.Windows.Forms.TextBox();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.lblHasil = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKalimat
            // 
            this.lblKalimat.AutoSize = true;
            this.lblKalimat.Location = new System.Drawing.Point(39, 44);
            this.lblKalimat.Name = "lblKalimat";
            this.lblKalimat.Size = new System.Drawing.Size(122, 17);
            this.lblKalimat.TabIndex = 0;
            this.lblKalimat.Text = "Masukkan Kalimat";
            // 
            // lblHuruf
            // 
            this.lblHuruf.AutoSize = true;
            this.lblHuruf.Location = new System.Drawing.Point(39, 98);
            this.lblHuruf.Name = "lblHuruf";
            this.lblHuruf.Size = new System.Drawing.Size(111, 17);
            this.lblHuruf.TabIndex = 1;
            this.lblHuruf.Text = "Masukkan Huruf";
            // 
            // tBoxInputKalimat
            // 
            this.tBoxInputKalimat.Location = new System.Drawing.Point(186, 41);
            this.tBoxInputKalimat.Name = "tBoxInputKalimat";
            this.tBoxInputKalimat.Size = new System.Drawing.Size(282, 22);
            this.tBoxInputKalimat.TabIndex = 2;
            // 
            // tBoxInputHuruf
            // 
            this.tBoxInputHuruf.Location = new System.Drawing.Point(186, 98);
            this.tBoxInputHuruf.Name = "tBoxInputHuruf";
            this.tBoxInputHuruf.Size = new System.Drawing.Size(62, 22);
            this.tBoxInputHuruf.TabIndex = 3;
            // 
            // lblMenjadi
            // 
            this.lblMenjadi.AutoSize = true;
            this.lblMenjadi.Location = new System.Drawing.Point(306, 101);
            this.lblMenjadi.Name = "lblMenjadi";
            this.lblMenjadi.Size = new System.Drawing.Size(57, 17);
            this.lblMenjadi.TabIndex = 4;
            this.lblMenjadi.Text = "Menjadi";
            // 
            // tBoxTujuanHuruf
            // 
            this.tBoxTujuanHuruf.Location = new System.Drawing.Point(406, 98);
            this.tBoxTujuanHuruf.Name = "tBoxTujuanHuruf";
            this.tBoxTujuanHuruf.Size = new System.Drawing.Size(62, 22);
            this.tBoxTujuanHuruf.TabIndex = 5;
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(215, 167);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(226, 23);
            this.btnKonversi.TabIndex = 6;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(39, 216);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(43, 17);
            this.lblHasil.TabIndex = 7;
            this.lblHasil.Text = "Hasil:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(183, 216);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 17);
            this.lblOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.tBoxTujuanHuruf);
            this.Controls.Add(this.lblMenjadi);
            this.Controls.Add(this.tBoxInputHuruf);
            this.Controls.Add(this.tBoxInputKalimat);
            this.Controls.Add(this.lblHuruf);
            this.Controls.Add(this.lblKalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKalimat;
        private System.Windows.Forms.Label lblHuruf;
        private System.Windows.Forms.TextBox tBoxInputKalimat;
        private System.Windows.Forms.TextBox tBoxInputHuruf;
        private System.Windows.Forms.Label lblMenjadi;
        private System.Windows.Forms.TextBox tBoxTujuanHuruf;
        private System.Windows.Forms.Button btnKonversi;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label lblOutput;
    }
}

