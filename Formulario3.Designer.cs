
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
            this.cmdForm4 = new System.Windows.Forms.Button();
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
            // cmdForm4
            // 
            this.cmdForm4.Location = new System.Drawing.Point(286, 373);
            this.cmdForm4.Name = "cmdForm4";
            this.cmdForm4.Size = new System.Drawing.Size(75, 23);
            this.cmdForm4.TabIndex = 1;
            this.cmdForm4.Text = "Ir a form 4";
            this.cmdForm4.UseVisualStyleBackColor = true;
            this.cmdForm4.Click += new System.EventHandler(this.cmdForm4_Click);
            // 
            // frmFormulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 456);
            this.Controls.Add(this.cmdForm4);
            this.Controls.Add(this.dgvForm3);
            this.Name = "frmFormulario3";
            this.Text = "Formulario3";
            this.Load += new System.EventHandler(this.Formulario3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForm3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvForm3;
        private System.Windows.Forms.Button cmdForm4;
    }
}