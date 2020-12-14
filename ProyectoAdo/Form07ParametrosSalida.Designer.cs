namespace ProyectoAdo
{
    partial class Form07ParametrosSalida
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
            this.cmbdepartamentos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstempleados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsumasalarial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamentos";
            // 
            // cmbdepartamentos
            // 
            this.cmbdepartamentos.FormattingEnabled = true;
            this.cmbdepartamentos.Location = new System.Drawing.Point(23, 123);
            this.cmbdepartamentos.Name = "cmbdepartamentos";
            this.cmbdepartamentos.Size = new System.Drawing.Size(248, 37);
            this.cmbdepartamentos.TabIndex = 1;
            this.cmbdepartamentos.SelectedIndexChanged += new System.EventHandler(this.cmbdepartamentos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleados";
            // 
            // lstempleados
            // 
            this.lstempleados.FormattingEnabled = true;
            this.lstempleados.ItemHeight = 29;
            this.lstempleados.Location = new System.Drawing.Point(301, 60);
            this.lstempleados.Name = "lstempleados";
            this.lstempleados.Size = new System.Drawing.Size(266, 294);
            this.lstempleados.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Suma salarial: ";
            // 
            // txtsumasalarial
            // 
            this.txtsumasalarial.Location = new System.Drawing.Point(23, 231);
            this.txtsumasalarial.Name = "txtsumasalarial";
            this.txtsumasalarial.Size = new System.Drawing.Size(243, 35);
            this.txtsumasalarial.TabIndex = 5;
            // 
            // Form07ParametrosSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 398);
            this.Controls.Add(this.txtsumasalarial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstempleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbdepartamentos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form07ParametrosSalida";
            this.Text = "Form07ParametrosSalida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbdepartamentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstempleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsumasalarial;
    }
}