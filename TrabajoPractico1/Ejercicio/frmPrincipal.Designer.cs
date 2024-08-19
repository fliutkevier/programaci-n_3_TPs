
namespace Ejercicio
{
    partial class frmPrincipal
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
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.btnEjercicio2 = new System.Windows.Forms.Button();
            this.btnEjercicio3 = new System.Windows.Forms.Button();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.lblIntegrante1 = new System.Windows.Forms.Label();
            this.lblIntegrante2 = new System.Windows.Forms.Label();
            this.lblIntegrante3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.Location = new System.Drawing.Point(12, 12);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(155, 44);
            this.btnEjercicio1.TabIndex = 0;
            this.btnEjercicio1.Text = "EJERCICIO 1";
            this.btnEjercicio1.UseVisualStyleBackColor = true;
            this.btnEjercicio1.Click += new System.EventHandler(this.btnEjercicio1_Click);
            // 
            // btnEjercicio2
            // 
            this.btnEjercicio2.Location = new System.Drawing.Point(190, 12);
            this.btnEjercicio2.Name = "btnEjercicio2";
            this.btnEjercicio2.Size = new System.Drawing.Size(155, 44);
            this.btnEjercicio2.TabIndex = 3;
            this.btnEjercicio2.Text = "EJERCICIO 2";
            this.btnEjercicio2.UseVisualStyleBackColor = true;
            this.btnEjercicio2.Click += new System.EventHandler(this.btnEjercicio2_Click);
            // 
            // btnEjercicio3
            // 
            this.btnEjercicio3.Location = new System.Drawing.Point(374, 12);
            this.btnEjercicio3.Name = "btnEjercicio3";
            this.btnEjercicio3.Size = new System.Drawing.Size(155, 44);
            this.btnEjercicio3.TabIndex = 4;
            this.btnEjercicio3.Text = "EJERCICIO 3";
            this.btnEjercicio3.UseVisualStyleBackColor = true;
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.Location = new System.Drawing.Point(30, 93);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(137, 25);
            this.lblIntegrantes.TabIndex = 5;
            this.lblIntegrantes.Text = "Integrantes:";
            // 
            // lblIntegrante1
            // 
            this.lblIntegrante1.AutoSize = true;
            this.lblIntegrante1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrante1.Location = new System.Drawing.Point(162, 130);
            this.lblIntegrante1.Name = "lblIntegrante1";
            this.lblIntegrante1.Size = new System.Drawing.Size(116, 16);
            this.lblIntegrante1.TabIndex = 6;
            this.lblIntegrante1.Text = "- Liutkevier Franco";
            // 
            // lblIntegrante2
            // 
            this.lblIntegrante2.AutoSize = true;
            this.lblIntegrante2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblIntegrante2.Location = new System.Drawing.Point(162, 146);
            this.lblIntegrante2.Name = "lblIntegrante2";
            this.lblIntegrante2.Size = new System.Drawing.Size(164, 16);
            this.lblIntegrante2.TabIndex = 7;
            this.lblIntegrante2.Text = "-Vitelli Sevillano Ignacio E.";
            this.lblIntegrante2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIntegrante3
            // 
            this.lblIntegrante3.AutoSize = true;
            this.lblIntegrante3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblIntegrante3.Location = new System.Drawing.Point(162, 162);
            this.lblIntegrante3.Name = "lblIntegrante3";
            this.lblIntegrante3.Size = new System.Drawing.Size(141, 16);
            this.lblIntegrante3.TabIndex = 8;
            this.lblIntegrante3.Text = "-Vercellini Maria Belen";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 288);
            this.Controls.Add(this.lblIntegrante3);
            this.Controls.Add(this.lblIntegrante2);
            this.Controls.Add(this.lblIntegrante1);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.btnEjercicio3);
            this.Controls.Add(this.btnEjercicio2);
            this.Controls.Add(this.btnEjercicio1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(561, 327);
            this.MinimumSize = new System.Drawing.Size(561, 327);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.Button btnEjercicio2;
        private System.Windows.Forms.Button btnEjercicio3;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label lblIntegrante1;
        private System.Windows.Forms.Label lblIntegrante2;
        private System.Windows.Forms.Label lblIntegrante3;
    }
}

