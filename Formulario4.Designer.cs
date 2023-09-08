
namespace Empresa
{
    partial class frmFormulario4
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
            this.cboSeleccione = new System.Windows.Forms.ComboBox();
            this.dgvForm4 = new System.Windows.Forms.DataGridView();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione";
            // 
            // cboSeleccione
            // 
            this.cboSeleccione.FormattingEnabled = true;
            this.cboSeleccione.Location = new System.Drawing.Point(175, 53);
            this.cboSeleccione.Name = "cboSeleccione";
            this.cboSeleccione.Size = new System.Drawing.Size(121, 21);
            this.cboSeleccione.TabIndex = 1;
            this.cboSeleccione.SelectedIndexChanged += new System.EventHandler(this.cboSeleccione_SelectedIndexChanged);
            // 
            // dgvForm4
            // 
            this.dgvForm4.AllowUserToAddRows = false;
            this.dgvForm4.AllowUserToDeleteRows = false;
            this.dgvForm4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForm4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dni,
            this.Nombre,
            this.Sueldo});
            this.dgvForm4.Location = new System.Drawing.Point(48, 116);
            this.dgvForm4.Name = "dgvForm4";
            this.dgvForm4.ReadOnly = true;
            this.dgvForm4.Size = new System.Drawing.Size(557, 245);
            this.dgvForm4.TabIndex = 2;
            // 
            // dni
            // 
            this.dni.HeaderText = "dni";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // frmFormulario4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 467);
            this.Controls.Add(this.dgvForm4);
            this.Controls.Add(this.cboSeleccione);
            this.Controls.Add(this.label1);
            this.Name = "frmFormulario4";
            this.Text = "Formulario4";
            this.Load += new System.EventHandler(this.Formulario4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSeleccione;
        private System.Windows.Forms.DataGridView dgvForm4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
    }
}