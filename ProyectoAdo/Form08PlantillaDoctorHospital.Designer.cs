namespace ProyectoAdo
{
    partial class Form08PlantillaDoctorHospital
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
            this.txtsumasalarial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstempleados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbhospitales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmediasalarial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumeroempleados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtsumasalarial
            // 
            this.txtsumasalarial.Location = new System.Drawing.Point(29, 178);
            this.txtsumasalarial.Name = "txtsumasalarial";
            this.txtsumasalarial.Size = new System.Drawing.Size(256, 35);
            this.txtsumasalarial.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Suma salarial: ";
            // 
            // lstempleados
            // 
            this.lstempleados.FormattingEnabled = true;
            this.lstempleados.ItemHeight = 29;
            this.lstempleados.Location = new System.Drawing.Point(334, 75);
            this.lstempleados.Name = "lstempleados";
            this.lstempleados.Size = new System.Drawing.Size(266, 352);
            this.lstempleados.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empleados";
            // 
            // cmbhospitales
            // 
            this.cmbhospitales.FormattingEnabled = true;
            this.cmbhospitales.Location = new System.Drawing.Point(29, 69);
            this.cmbhospitales.Name = "cmbhospitales";
            this.cmbhospitales.Size = new System.Drawing.Size(256, 37);
            this.cmbhospitales.TabIndex = 7;
            this.cmbhospitales.SelectedIndexChanged += new System.EventHandler(this.cmbhospitales_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hospitales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Media salarial:";
            // 
            // txtmediasalarial
            // 
            this.txtmediasalarial.Location = new System.Drawing.Point(29, 271);
            this.txtmediasalarial.Name = "txtmediasalarial";
            this.txtmediasalarial.Size = new System.Drawing.Size(256, 35);
            this.txtmediasalarial.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Número de empleados:";
            // 
            // txtnumeroempleados
            // 
            this.txtnumeroempleados.Location = new System.Drawing.Point(29, 357);
            this.txtnumeroempleados.Name = "txtnumeroempleados";
            this.txtnumeroempleados.Size = new System.Drawing.Size(256, 35);
            this.txtnumeroempleados.TabIndex = 15;
            // 
            // Form08DoctoresPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 480);
            this.Controls.Add(this.txtnumeroempleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmediasalarial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsumasalarial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstempleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbhospitales);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form08DoctoresPlantilla";
            this.Text = "Form08DoctoresPlantilla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsumasalarial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstempleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbhospitales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmediasalarial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumeroempleados;
    }
}