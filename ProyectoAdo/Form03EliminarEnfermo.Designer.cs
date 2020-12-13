namespace ProyectoAdo
{
    partial class Form03EliminarEnfermo
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstenfermos = new System.Windows.Forms.ListBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtinscripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enfermos";
            // 
            // lstenfermos
            // 
            this.lstenfermos.FormattingEnabled = true;
            this.lstenfermos.ItemHeight = 25;
            this.lstenfermos.Location = new System.Drawing.Point(17, 219);
            this.lstenfermos.Name = "lstenfermos";
            this.lstenfermos.Size = new System.Drawing.Size(327, 304);
            this.lstenfermos.TabIndex = 8;
            // 
            // btneliminar
            // 
            this.btneliminar.ForeColor = System.Drawing.Color.Red;
            this.btneliminar.Location = new System.Drawing.Point(17, 101);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(327, 49);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtinscripcion
            // 
            this.txtinscripcion.Location = new System.Drawing.Point(47, 51);
            this.txtinscripcion.Name = "txtinscripcion";
            this.txtinscripcion.Size = new System.Drawing.Size(272, 31);
            this.txtinscripcion.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inscripción";
            // 
            // Form03EliminarEnfermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstenfermos);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.txtinscripcion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form03EliminarEnfermo";
            this.Text = "Form03EliminarEnfermo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstenfermos;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtinscripcion;
        private System.Windows.Forms.Label label1;
    }
}