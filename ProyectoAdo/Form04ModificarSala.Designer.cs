namespace ProyectoAdo
{
    partial class Form04ModificarSala
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstsalas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnuevonombre = new System.Windows.Forms.TextBox();
            this.btnmodificarsala = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salas";
            // 
            // lstsalas
            // 
            this.lstsalas.FormattingEnabled = true;
            this.lstsalas.ItemHeight = 29;
            this.lstsalas.Location = new System.Drawing.Point(36, 74);
            this.lstsalas.Name = "lstsalas";
            this.lstsalas.Size = new System.Drawing.Size(247, 265);
            this.lstsalas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo nombre";
            // 
            // txtnuevonombre
            // 
            this.txtnuevonombre.Location = new System.Drawing.Point(332, 118);
            this.txtnuevonombre.Name = "txtnuevonombre";
            this.txtnuevonombre.Size = new System.Drawing.Size(233, 35);
            this.txtnuevonombre.TabIndex = 3;
            // 
            // btnmodificarsala
            // 
            this.btnmodificarsala.Location = new System.Drawing.Point(370, 200);
            this.btnmodificarsala.Name = "btnmodificarsala";
            this.btnmodificarsala.Size = new System.Drawing.Size(157, 80);
            this.btnmodificarsala.TabIndex = 4;
            this.btnmodificarsala.Text = "Modificar sala";
            this.btnmodificarsala.UseVisualStyleBackColor = true;
            this.btnmodificarsala.Click += new System.EventHandler(this.btnmodificarsala_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblresultado.Location = new System.Drawing.Point(327, 310);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 29);
            this.lblresultado.TabIndex = 5;
            // 
            // Form04ModificarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 398);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnmodificarsala);
            this.Controls.Add(this.txtnuevonombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstsalas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form04ModificarSala";
            this.Text = "Form04ModificarSala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstsalas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnuevonombre;
        private System.Windows.Forms.Button btnmodificarsala;
        private System.Windows.Forms.Label lblresultado;
    }
}