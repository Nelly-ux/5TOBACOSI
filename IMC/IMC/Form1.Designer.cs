namespace IMC
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.cmdres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(99, 43);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(127, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Calculadora de IMC";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(99, 140);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(103, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Estatura: Metros";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(99, 235);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(108, 16);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Peso: Kilogramos";
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(255, 132);
            this.txtv1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(116, 22);
            this.txtv1.TabIndex = 3;
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(255, 227);
            this.txtv2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(116, 22);
            this.txtv2.TabIndex = 4;
            // 
            // cmdres
            // 
            this.cmdres.Location = new System.Drawing.Point(146, 363);
            this.cmdres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdres.Name = "cmdres";
            this.cmdres.Size = new System.Drawing.Size(169, 43);
            this.cmdres.TabIndex = 5;
            this.cmdres.Text = "calcular";
            this.cmdres.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 557);
            this.Controls.Add(this.cmdres);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.Button cmdres;
    }
}

