
namespace Ejercicio
{
    partial class frmEjercicio1
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIngreseNombre = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lbDerecha = new System.Windows.Forms.ListBox();
            this.btnPasarTodos = new System.Windows.Forms.Button();
            this.btnPasarNombre = new System.Windows.Forms.Button();
            this.lbIzquierda = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(453, 396);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 31);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(454, 48);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 34);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIngreseNombre
            // 
            this.lblIngreseNombre.AutoSize = true;
            this.lblIngreseNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseNombre.Location = new System.Drawing.Point(12, 54);
            this.lblIngreseNombre.Name = "lblIngreseNombre";
            this.lblIngreseNombre.Size = new System.Drawing.Size(165, 20);
            this.lblIngreseNombre.TabIndex = 2;
            this.lblIngreseNombre.Text = "Ingrese un nombre:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(183, 54);
            this.tbxNombre.MaxLength = 30;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(252, 20);
            this.tbxNombre.TabIndex = 3;
            // 
            // lbDerecha
            // 
            this.lbDerecha.FormattingEnabled = true;
            this.lbDerecha.Location = new System.Drawing.Point(372, 116);
            this.lbDerecha.Name = "lbDerecha";
            this.lbDerecha.Size = new System.Drawing.Size(192, 238);
            this.lbDerecha.TabIndex = 5;
            // 
            // btnPasarTodos
            // 
            this.btnPasarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarTodos.Location = new System.Drawing.Point(255, 252);
            this.btnPasarTodos.Name = "btnPasarTodos";
            this.btnPasarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnPasarTodos.TabIndex = 6;
            this.btnPasarTodos.Text = ">>";
            this.btnPasarTodos.UseVisualStyleBackColor = true;
            this.btnPasarTodos.Click += new System.EventHandler(this.btnPasarTodos_Click);
            // 
            // btnPasarNombre
            // 
            this.btnPasarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarNombre.Location = new System.Drawing.Point(255, 174);
            this.btnPasarNombre.Name = "btnPasarNombre";
            this.btnPasarNombre.Size = new System.Drawing.Size(75, 23);
            this.btnPasarNombre.TabIndex = 7;
            this.btnPasarNombre.Text = ">";
            this.btnPasarNombre.UseVisualStyleBackColor = true;
            this.btnPasarNombre.Click += new System.EventHandler(this.btnPasarNombre_Click);
            // 
            // lbIzquierda
            // 
            this.lbIzquierda.FormattingEnabled = true;
            this.lbIzquierda.Location = new System.Drawing.Point(12, 116);
            this.lbIzquierda.Name = "lbIzquierda";
            this.lbIzquierda.Size = new System.Drawing.Size(192, 238);
            this.lbIzquierda.TabIndex = 8;
            // 
            // frmEjercicio1
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.lbIzquierda);
            this.Controls.Add(this.btnPasarNombre);
            this.Controls.Add(this.btnPasarTodos);
            this.Controls.Add(this.lbDerecha);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblIngreseNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCerrar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(602, 489);
            this.MinimumSize = new System.Drawing.Size(602, 489);
            this.Name = "frmEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIngreseNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.ListBox lbDerecha;
        private System.Windows.Forms.Button btnPasarTodos;
        private System.Windows.Forms.Button btnPasarNombre;
        private System.Windows.Forms.ListBox lbIzquierda;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}