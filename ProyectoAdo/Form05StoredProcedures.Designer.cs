namespace ProyectoAdo
{
    partial class Form05StoredProcedures
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
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.btnbuscarempleados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstempleados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(32, 73);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(312, 35);
            this.txtapellido.TabIndex = 1;
            // 
            // btnbuscarempleados
            // 
            this.btnbuscarempleados.Location = new System.Drawing.Point(32, 115);
            this.btnbuscarempleados.Name = "btnbuscarempleados";
            this.btnbuscarempleados.Size = new System.Drawing.Size(312, 37);
            this.btnbuscarempleados.TabIndex = 2;
            this.btnbuscarempleados.Text = "Buscar empleados";
            this.btnbuscarempleados.UseVisualStyleBackColor = true;
            this.btnbuscarempleados.Click += new System.EventHandler(this.btnbuscarempleados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleados";
            // 
            // lstempleados
            // 
            this.lstempleados.FormattingEnabled = true;
            this.lstempleados.ItemHeight = 29;
            this.lstempleados.Location = new System.Drawing.Point(32, 215);
            this.lstempleados.Name = "lstempleados";
            this.lstempleados.Size = new System.Drawing.Size(312, 323);
            this.lstempleados.TabIndex = 4;
            // 
            // Form05StoredProcedures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 579);
            this.Controls.Add(this.lstempleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnbuscarempleados);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form05StoredProcedures";
            this.Text = "Form05StoredProcedures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Button btnbuscarempleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstempleados;
    }
}