namespace ProyectoAdo
{
    partial class Form01PrimerAdo
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
            this.btnconectar = new System.Windows.Forms.Button();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.btnleerdatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstapellidos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstcolumnas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lsttipos = new System.Windows.Forms.ListBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconectar
            // 
            this.btnconectar.Location = new System.Drawing.Point(17, 23);
            this.btnconectar.Name = "btnconectar";
            this.btnconectar.Size = new System.Drawing.Size(161, 63);
            this.btnconectar.TabIndex = 0;
            this.btnconectar.Text = "Conectar";
            this.btnconectar.UseVisualStyleBackColor = true;
            this.btnconectar.Click += new System.EventHandler(this.btnconectar_Click);
            // 
            // btndesconectar
            // 
            this.btndesconectar.Location = new System.Drawing.Point(17, 104);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(161, 63);
            this.btndesconectar.TabIndex = 1;
            this.btndesconectar.Text = "Desconectar";
            this.btndesconectar.UseVisualStyleBackColor = true;
            this.btndesconectar.Click += new System.EventHandler(this.btndesconectar_Click);
            // 
            // btnleerdatos
            // 
            this.btnleerdatos.Location = new System.Drawing.Point(17, 189);
            this.btnleerdatos.Name = "btnleerdatos";
            this.btnleerdatos.Size = new System.Drawing.Size(161, 63);
            this.btnleerdatos.TabIndex = 2;
            this.btnleerdatos.Text = "Leer datos";
            this.btnleerdatos.UseVisualStyleBackColor = true;
            this.btnleerdatos.Click += new System.EventHandler(this.btnleerdatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apellidos";
            // 
            // lstapellidos
            // 
            this.lstapellidos.FormattingEnabled = true;
            this.lstapellidos.ItemHeight = 25;
            this.lstapellidos.Location = new System.Drawing.Point(202, 41);
            this.lstapellidos.Name = "lstapellidos";
            this.lstapellidos.Size = new System.Drawing.Size(164, 254);
            this.lstapellidos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columnas";
            // 
            // lstcolumnas
            // 
            this.lstcolumnas.FormattingEnabled = true;
            this.lstcolumnas.ItemHeight = 25;
            this.lstcolumnas.Location = new System.Drawing.Point(386, 41);
            this.lstcolumnas.Name = "lstcolumnas";
            this.lstcolumnas.Size = new System.Drawing.Size(164, 254);
            this.lstcolumnas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipos";
            // 
            // lsttipos
            // 
            this.lsttipos.FormattingEnabled = true;
            this.lsttipos.ItemHeight = 25;
            this.lsttipos.Location = new System.Drawing.Point(570, 41);
            this.lsttipos.Name = "lsttipos";
            this.lsttipos.Size = new System.Drawing.Size(164, 254);
            this.lsttipos.TabIndex = 8;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(12, 312);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(99, 25);
            this.lblestado.TabIndex = 9;
            this.lblestado.Text = "lblestado";
            // 
            // Form01PrimerAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 372);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lsttipos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstcolumnas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstapellidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnleerdatos);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.btnconectar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form01PrimerAdo";
            this.Text = "Form01PrimerAdo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconectar;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.Button btnleerdatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstapellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstcolumnas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsttipos;
        private System.Windows.Forms.Label lblestado;
    }
}