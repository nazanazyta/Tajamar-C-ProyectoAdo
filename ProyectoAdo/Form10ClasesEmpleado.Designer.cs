namespace ProyectoAdo
{
    partial class Form10ClasesEmpleado
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
            this.cmboficios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvempleados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.txtincremento = new System.Windows.Forms.TextBox();
            this.btnincrementar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oficios";
            // 
            // cmboficios
            // 
            this.cmboficios.FormattingEnabled = true;
            this.cmboficios.Location = new System.Drawing.Point(18, 46);
            this.cmboficios.Name = "cmboficios";
            this.cmboficios.Size = new System.Drawing.Size(227, 37);
            this.cmboficios.TabIndex = 1;
            this.cmboficios.SelectedIndexChanged += new System.EventHandler(this.cmboficios_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleados";
            // 
            // lsvempleados
            // 
            this.lsvempleados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvempleados.HideSelection = false;
            this.lsvempleados.Location = new System.Drawing.Point(18, 157);
            this.lsvempleados.Name = "lsvempleados";
            this.lsvempleados.Size = new System.Drawing.Size(619, 265);
            this.lsvempleados.TabIndex = 3;
            this.lsvempleados.UseCompatibleStateImageBehavior = false;
            this.lsvempleados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Empleado";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            this.columnHeader2.Width = 176;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oficio";
            this.columnHeader3.Width = 158;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Salario";
            this.columnHeader4.Width = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Incremento salarial:";
            // 
            // txtincremento
            // 
            this.txtincremento.Location = new System.Drawing.Point(331, 46);
            this.txtincremento.Name = "txtincremento";
            this.txtincremento.Size = new System.Drawing.Size(217, 35);
            this.txtincremento.TabIndex = 5;
            // 
            // btnincrementar
            // 
            this.btnincrementar.Location = new System.Drawing.Point(331, 99);
            this.btnincrementar.Name = "btnincrementar";
            this.btnincrementar.Size = new System.Drawing.Size(245, 40);
            this.btnincrementar.TabIndex = 6;
            this.btnincrementar.Text = "Incrementar salarios";
            this.btnincrementar.UseVisualStyleBackColor = true;
            this.btnincrementar.Click += new System.EventHandler(this.btnincrementar_Click);
            // 
            // Form10ClasesEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 445);
            this.Controls.Add(this.btnincrementar);
            this.Controls.Add(this.txtincremento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvempleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboficios);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form10ClasesEmpleado";
            this.Text = "Form10ClasesEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboficios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvempleados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtincremento;
        private System.Windows.Forms.Button btnincrementar;
    }
}