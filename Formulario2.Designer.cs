
namespace Empresa
{
    partial class frmFormulario2
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
            this.cboNombre = new System.Windows.Forms.ComboBox();
            this.lstNombre = new System.Windows.Forms.ListBox();
            this.cmdFrm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboNombre
            // 
            this.cboNombre.FormattingEnabled = true;
            this.cboNombre.Location = new System.Drawing.Point(184, 78);
            this.cboNombre.Name = "cboNombre";
            this.cboNombre.Size = new System.Drawing.Size(121, 21);
            this.cboNombre.TabIndex = 0;
            this.cboNombre.SelectedIndexChanged += new System.EventHandler(this.cboNombre_SelectedIndexChanged);
            // 
            // lstNombre
            // 
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.Location = new System.Drawing.Point(219, 126);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(120, 95);
            this.lstNombre.TabIndex = 1;
            // 
            // cmdFrm3
            // 
            this.cmdFrm3.Location = new System.Drawing.Point(252, 323);
            this.cmdFrm3.Name = "cmdFrm3";
            this.cmdFrm3.Size = new System.Drawing.Size(75, 23);
            this.cmdFrm3.TabIndex = 2;
            this.cmdFrm3.Text = "Ir a frm3";
            this.cmdFrm3.UseVisualStyleBackColor = true;
            this.cmdFrm3.Click += new System.EventHandler(this.cmdFrm3_Click);
            // 
            // frmFormulario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 455);
            this.Controls.Add(this.cmdFrm3);
            this.Controls.Add(this.lstNombre);
            this.Controls.Add(this.cboNombre);
            this.Name = "frmFormulario2";
            this.Text = "Formulario2";
            this.Load += new System.EventHandler(this.frmFormulario2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNombre;
        private System.Windows.Forms.ListBox lstNombre;
        private System.Windows.Forms.Button cmdFrm3;
    }
}