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
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.cmdres = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.lblimc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(250, 57);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(127, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Calculadora de IMC";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(255, 225);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(103, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Estatura: Metros";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(255, 140);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(108, 16);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Peso: Kilogramos";
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(411, 217);
            this.txtv2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(116, 22);
            this.txtv2.TabIndex = 3;
            this.txtv2.TextChanged += new System.EventHandler(this.txtv1_TextChanged);
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(411, 132);
            this.txtv1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(116, 22);
            this.txtv1.TabIndex = 4;
            // 
            // cmdres
            // 
            this.cmdres.Location = new System.Drawing.Point(270, 342);
            this.cmdres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdres.Name = "cmdres";
            this.cmdres.Size = new System.Drawing.Size(169, 43);
            this.cmdres.TabIndex = 5;
            this.cmdres.Text = "calcular";
            this.cmdres.UseVisualStyleBackColor = true;
            this.cmdres.Click += new System.EventHandler(this.cmdres_Click);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(403, 440);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(15, 16);
            this.lblres.TabIndex = 6;
            this.lblres.Text = "0";
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Location = new System.Drawing.Point(267, 440);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(86, 16);
            this.lblimc.TabIndex = 7;
            this.lblimc.Text = "Su IMC es de:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 149);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(770, 557);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.cmdres);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtv2;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.Button cmdres;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

