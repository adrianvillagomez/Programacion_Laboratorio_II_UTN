namespace WinFormsI02
{
    partial class FrmMain
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
            this.gbUno = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.CbJavascrip = new System.Windows.Forms.CheckBox();
            this.cbCursosC = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.listBoxPaises = new System.Windows.Forms.ListBox();
            this.lvlPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gbUno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.gbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUno
            // 
            this.gbUno.Controls.Add(this.lblEdad);
            this.gbUno.Controls.Add(this.lblDireccion);
            this.gbUno.Controls.Add(this.lblNombre);
            this.gbUno.Controls.Add(this.numericUpDown1);
            this.gbUno.Controls.Add(this.txtDireccion);
            this.gbUno.Controls.Add(this.txtNombre);
            this.gbUno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbUno.Location = new System.Drawing.Point(29, 25);
            this.gbUno.Name = "gbUno";
            this.gbUno.Size = new System.Drawing.Size(246, 158);
            this.gbUno.TabIndex = 0;
            this.gbUno.TabStop = false;
            this.gbUno.Text = "Detalles del Usuario";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(28, 124);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(27, 75);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(123, 119);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown1.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(123, 72);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 23);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbNoBinario);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbGenero.Location = new System.Drawing.Point(332, 25);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(124, 95);
            this.gbGenero.TabIndex = 1;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Genero";
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbNoBinario.Location = new System.Drawing.Point(16, 71);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rbNoBinario.TabIndex = 2;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No Binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFemenino.Location = new System.Drawing.Point(16, 47);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMasculino.Location = new System.Drawing.Point(16, 22);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.CbJavascrip);
            this.gbCursos.Controls.Add(this.cbCursosC);
            this.gbCursos.Controls.Add(this.cbC);
            this.gbCursos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbCursos.Location = new System.Drawing.Point(332, 136);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(124, 112);
            this.gbCursos.TabIndex = 2;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // CbJavascrip
            // 
            this.CbJavascrip.AutoSize = true;
            this.CbJavascrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbJavascrip.Location = new System.Drawing.Point(18, 79);
            this.CbJavascrip.Name = "CbJavascrip";
            this.CbJavascrip.Size = new System.Drawing.Size(78, 19);
            this.CbJavascrip.TabIndex = 2;
            this.CbJavascrip.Text = "JavaScript";
            this.CbJavascrip.UseVisualStyleBackColor = true;
            // 
            // cbCursosC
            // 
            this.cbCursosC.AutoSize = true;
            this.cbCursosC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCursosC.Location = new System.Drawing.Point(18, 54);
            this.cbCursosC.Name = "cbCursosC";
            this.cbCursosC.Size = new System.Drawing.Size(50, 19);
            this.cbCursosC.TabIndex = 1;
            this.cbCursosC.Text = "C++";
            this.cbCursosC.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbC.Location = new System.Drawing.Point(18, 29);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(41, 19);
            this.cbC.TabIndex = 0;
            this.cbC.Text = "C#";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // listBoxPaises
            // 
            this.listBoxPaises.FormattingEnabled = true;
            this.listBoxPaises.ItemHeight = 15;
            this.listBoxPaises.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.listBoxPaises.Location = new System.Drawing.Point(29, 238);
            this.listBoxPaises.Name = "listBoxPaises";
            this.listBoxPaises.Size = new System.Drawing.Size(246, 94);
            this.listBoxPaises.TabIndex = 3;
            // 
            // lvlPais
            // 
            this.lvlPais.AutoSize = true;
            this.lvlPais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvlPais.Location = new System.Drawing.Point(29, 220);
            this.lvlPais.Name = "lvlPais";
            this.lvlPais.Size = new System.Drawing.Size(28, 15);
            this.lvlPais.TabIndex = 4;
            this.lvlPais.Text = "Pais";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(332, 276);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(114, 35);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 369);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lvlPais);
            this.Controls.Add(this.listBoxPaises);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbUno);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.gbUno.ResumeLayout(false);
            this.gbUno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            this.gbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUno;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.CheckBox CbJavascrip;
        private System.Windows.Forms.CheckBox cbCursosC;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.ListBox listBoxPaises;
        private System.Windows.Forms.Label lvlPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}
