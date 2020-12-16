
namespace ProyectoAdo
{
    partial class Form11HospitalesPlantillaPaco
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
            this.pnlhospitales = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lsvplantilla = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // pnlhospitales
            // 
            this.pnlhospitales.BackColor = System.Drawing.Color.Khaki;
            this.pnlhospitales.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlhospitales.Location = new System.Drawing.Point(0, 0);
            this.pnlhospitales.Name = "pnlhospitales";
            this.pnlhospitales.Size = new System.Drawing.Size(205, 566);
            this.pnlhospitales.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(205, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 566);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lsvplantilla
            // 
            this.lsvplantilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvplantilla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvplantilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvplantilla.FullRowSelect = true;
            this.lsvplantilla.GridLines = true;
            this.lsvplantilla.HideSelection = false;
            this.lsvplantilla.Location = new System.Drawing.Point(208, 0);
            this.lsvplantilla.Name = "lsvplantilla";
            this.lsvplantilla.Size = new System.Drawing.Size(653, 566);
            this.lsvplantilla.TabIndex = 0;
            this.lsvplantilla.UseCompatibleStateImageBehavior = false;
            this.lsvplantilla.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Apellido";
            this.columnHeader1.Width = 171;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Función";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salario";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hospital";
            this.columnHeader4.Width = 188;
            // 
            // Form11HospitalesPlantillaPaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 566);
            this.Controls.Add(this.lsvplantilla);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlhospitales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form11HospitalesPlantillaPaco";
            this.Text = "Form11HospitalesPlantillaPaco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlhospitales;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lsvplantilla;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}