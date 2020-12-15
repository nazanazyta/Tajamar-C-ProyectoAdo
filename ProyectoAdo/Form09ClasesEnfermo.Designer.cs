namespace ProyectoAdo
{
    partial class Form09ClasesEnfermo
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
            this.lsvenfermos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvenfermos
            // 
            this.lsvenfermos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvenfermos.FullRowSelect = true;
            this.lsvenfermos.HideSelection = false;
            this.lsvenfermos.Location = new System.Drawing.Point(30, 41);
            this.lsvenfermos.Name = "lsvenfermos";
            this.lsvenfermos.Size = new System.Drawing.Size(784, 345);
            this.lsvenfermos.TabIndex = 0;
            this.lsvenfermos.UseCompatibleStateImageBehavior = false;
            this.lsvenfermos.View = System.Windows.Forms.View.Details;
            //this.lsvenfermos.SelectedIndexChanged += new System.EventHandler(this.lsvenfermos_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Inscripción";
            this.columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido";
            this.columnHeader2.Width = 174;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Dirección";
            this.columnHeader3.Width = 196;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha de nacimiento";
            this.columnHeader4.Width = 240;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enfermos";
            // 
            // btneliminar
            // 
            this.btneliminar.ForeColor = System.Drawing.Color.Red;
            this.btneliminar.Location = new System.Drawing.Point(30, 424);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(184, 48);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // Form09ClasesEnfermo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 487);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvenfermos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form09ClasesEnfermo";
            this.Text = "Form09ClasesEnfermo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvenfermos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneliminar;
    }
}