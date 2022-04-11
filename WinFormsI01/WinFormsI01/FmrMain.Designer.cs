namespace WinFormsI01
{
    partial class FmrMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btSaludar = new System.Windows.Forms.Button();
            this.cmbMateriaFavorita = new System.Windows.Forms.ComboBox();
            this.lvlMateriFavorita = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorApellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(239, 109);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(101, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(420, 109);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(101, 23);
            this.txtApellido.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(242, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre : ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(420, 79);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido :";
            // 
            // btSaludar
            // 
            this.btSaludar.Location = new System.Drawing.Point(525, 182);
            this.btSaludar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSaludar.Name = "btSaludar";
            this.btSaludar.Size = new System.Drawing.Size(139, 34);
            this.btSaludar.TabIndex = 4;
            this.btSaludar.Text = "Saludar";
            this.btSaludar.UseVisualStyleBackColor = true;
            this.btSaludar.Click += new System.EventHandler(this.btSaludar_Click);
            // 
            // cmbMateriaFavorita
            // 
            this.cmbMateriaFavorita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaFavorita.FormattingEnabled = true;
            this.cmbMateriaFavorita.Location = new System.Drawing.Point(63, 165);
            this.cmbMateriaFavorita.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMateriaFavorita.Name = "cmbMateriaFavorita";
            this.cmbMateriaFavorita.Size = new System.Drawing.Size(178, 23);
            this.cmbMateriaFavorita.TabIndex = 5;
            // 
            // lvlMateriFavorita
            // 
            this.lvlMateriFavorita.AutoSize = true;
            this.lvlMateriFavorita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvlMateriFavorita.Location = new System.Drawing.Point(63, 148);
            this.lvlMateriFavorita.Name = "lvlMateriFavorita";
            this.lvlMateriFavorita.Size = new System.Drawing.Size(98, 15);
            this.lvlMateriFavorita.TabIndex = 6;
            this.lvlMateriFavorita.Text = "Materia Favorita";
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblErrorNombre.Location = new System.Drawing.Point(239, 135);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(132, 15);
            this.lblErrorNombre.TabIndex = 7;
            this.lblErrorNombre.Text = "Error,ingrese solo letras.";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorApellido
            // 
            this.lblErrorApellido.AutoSize = true;
            this.lblErrorApellido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblErrorApellido.Location = new System.Drawing.Point(421, 138);
            this.lblErrorApellido.Name = "lblErrorApellido";
            this.lblErrorApellido.Size = new System.Drawing.Size(132, 15);
            this.lblErrorApellido.TabIndex = 8;
            this.lblErrorApellido.Text = "Error,ingrese solo letras.";
            this.lblErrorApellido.Visible = false;
            // 
            // FmrMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 291);
            this.Controls.Add(this.lblErrorApellido);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lvlMateriFavorita);
            this.Controls.Add(this.cmbMateriaFavorita);
            this.Controls.Add(this.btSaludar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmrMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hola,Windows Forms!";
            this.Load += new System.EventHandler(this.FmrMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btSaludar;
        private System.Windows.Forms.ComboBox cmbMateriaFavorita;
        private System.Windows.Forms.Label lvlMateriFavorita;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorApellido;
    }
}
