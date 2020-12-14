namespace ProyectoAdo
{
    partial class Form06MensajesServidor
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstdepartamentos = new System.Windows.Forms.ListBox();
            this.btninsertardepartamento = new System.Windows.Forms.Button();
            this.lblmensajes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(28, 55);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(124, 38);
            this.txtnumero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(28, 141);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(230, 38);
            this.txtnombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Localidad";
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Location = new System.Drawing.Point(28, 227);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(230, 38);
            this.txtlocalidad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Departamentos";
            // 
            // lstdepartamentos
            // 
            this.lstdepartamentos.FormattingEnabled = true;
            this.lstdepartamentos.ItemHeight = 31;
            this.lstdepartamentos.Location = new System.Drawing.Point(283, 57);
            this.lstdepartamentos.Name = "lstdepartamentos";
            this.lstdepartamentos.Size = new System.Drawing.Size(447, 314);
            this.lstdepartamentos.TabIndex = 7;
            // 
            // btninsertardepartamento
            // 
            this.btninsertardepartamento.Location = new System.Drawing.Point(28, 299);
            this.btninsertardepartamento.Name = "btninsertardepartamento";
            this.btninsertardepartamento.Size = new System.Drawing.Size(230, 72);
            this.btninsertardepartamento.TabIndex = 8;
            this.btninsertardepartamento.Text = "Insertar departamento";
            this.btninsertardepartamento.UseVisualStyleBackColor = true;
            this.btninsertardepartamento.Click += new System.EventHandler(this.btninsertardepartamento_Click);
            // 
            // lblmensajes
            // 
            this.lblmensajes.AutoSize = true;
            this.lblmensajes.ForeColor = System.Drawing.Color.Red;
            this.lblmensajes.Location = new System.Drawing.Point(22, 397);
            this.lblmensajes.Name = "lblmensajes";
            this.lblmensajes.Size = new System.Drawing.Size(157, 31);
            this.lblmensajes.TabIndex = 9;
            this.lblmensajes.Text = "lblmensajes";
            // 
            // Form06MensajesServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 459);
            this.Controls.Add(this.lblmensajes);
            this.Controls.Add(this.btninsertardepartamento);
            this.Controls.Add(this.lstdepartamentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtlocalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form06MensajesServidor";
            this.Text = "Form06MensajesServidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstdepartamentos;
        private System.Windows.Forms.Button btninsertardepartamento;
        private System.Windows.Forms.Label lblmensajes;
    }
}