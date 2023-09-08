
namespace Empresa
{
    partial class frmFormulario3
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
            this.dgvForm3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvForm3
            // 
            this.dgvForm3.AllowUserToAddRows = false;
            this.dgvForm3.AllowUserToDeleteRows = false;
            this.dgvForm3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForm3.Location = new System.Drawing.Point(0, 0);
            this.dgvForm3.Name = "dgvForm3";
            this.dgvForm3.ReadOnly = true;
            this.dgvForm3.Size = new System.Drawing.Size(432, 342);
            this.dgvForm3.TabIndex = 0;
            // 
            // frmFormulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 456);
            this.Controls.Add(this.dgvForm3);
            this.Name = "frmFormulario3";
            this.Text = "Formulario3";
            this.Load += new System.EventHandler(this.Formulario3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvForm3;
    }
}