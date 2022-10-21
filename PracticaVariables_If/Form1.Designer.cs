namespace PracticaVariables_If
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btbImprimir = new System.Windows.Forms.Button();
            this.ibiNota1 = new System.Windows.Forms.Label();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.ibiNota2 = new System.Windows.Forms.Label();
            this.ibiNota3 = new System.Windows.Forms.Label();
            this.ibiNota4 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btbImprimir
            // 
            this.btbImprimir.Location = new System.Drawing.Point(488, 172);
            this.btbImprimir.Name = "btbImprimir";
            this.btbImprimir.Size = new System.Drawing.Size(132, 39);
            this.btbImprimir.TabIndex = 0;
            this.btbImprimir.Text = "Imprimir";
            this.btbImprimir.UseVisualStyleBackColor = true;
            this.btbImprimir.Click += new System.EventHandler(this.btbImprimir_Click);
            // 
            // ibiNota1
            // 
            this.ibiNota1.AutoSize = true;
            this.ibiNota1.Location = new System.Drawing.Point(121, 70);
            this.ibiNota1.Name = "ibiNota1";
            this.ibiNota1.Size = new System.Drawing.Size(49, 16);
            this.ibiNota1.TabIndex = 1;
            this.ibiNota1.Text = "Nota 1:";
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(252, 293);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 22);
            this.txtNota4.TabIndex = 2;
            // 
            // ibiNota2
            // 
            this.ibiNota2.AutoSize = true;
            this.ibiNota2.Location = new System.Drawing.Point(121, 133);
            this.ibiNota2.Name = "ibiNota2";
            this.ibiNota2.Size = new System.Drawing.Size(49, 16);
            this.ibiNota2.TabIndex = 3;
            this.ibiNota2.Text = "Nota 2:";
            // 
            // ibiNota3
            // 
            this.ibiNota3.AutoSize = true;
            this.ibiNota3.Location = new System.Drawing.Point(121, 213);
            this.ibiNota3.Name = "ibiNota3";
            this.ibiNota3.Size = new System.Drawing.Size(49, 16);
            this.ibiNota3.TabIndex = 4;
            this.ibiNota3.Text = "Nota 3:";
            // 
            // ibiNota4
            // 
            this.ibiNota4.AutoSize = true;
            this.ibiNota4.Location = new System.Drawing.Point(121, 293);
            this.ibiNota4.Name = "ibiNota4";
            this.ibiNota4.Size = new System.Drawing.Size(49, 16);
            this.ibiNota4.TabIndex = 5;
            this.ibiNota4.Text = "Nota 4:";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(252, 207);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 22);
            this.txtNota3.TabIndex = 6;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(252, 127);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 22);
            this.txtNota2.TabIndex = 7;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(252, 70);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 22);
            this.txtNota1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.ibiNota4);
            this.Controls.Add(this.ibiNota3);
            this.Controls.Add(this.ibiNota2);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.ibiNota1);
            this.Controls.Add(this.btbImprimir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbImprimir;
        private System.Windows.Forms.Label ibiNota1;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Label ibiNota2;
        private System.Windows.Forms.Label ibiNota3;
        private System.Windows.Forms.Label ibiNota4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
    }
}

