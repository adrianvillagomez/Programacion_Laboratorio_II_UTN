﻿namespace Competencias
{
    partial class frmTorneo
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
            this.cmbEquipoUno = new System.Windows.Forms.ComboBox();
            this.cmbEquipoDos = new System.Windows.Forms.ComboBox();
            this.btnDesafiar = new System.Windows.Forms.Button();
            this.rchtDatosTorneo = new System.Windows.Forms.RichTextBox();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEquipoUno
            // 
            this.cmbEquipoUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipoUno.FormattingEnabled = true;
            this.cmbEquipoUno.Location = new System.Drawing.Point(30, 12);
            this.cmbEquipoUno.Name = "cmbEquipoUno";
            this.cmbEquipoUno.Size = new System.Drawing.Size(390, 23);
            this.cmbEquipoUno.TabIndex = 0;
            this.cmbEquipoUno.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoUno_SelectedIndexChanged);
            // 
            // cmbEquipoDos
            // 
            this.cmbEquipoDos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipoDos.FormattingEnabled = true;
            this.cmbEquipoDos.Location = new System.Drawing.Point(441, 12);
            this.cmbEquipoDos.Name = "cmbEquipoDos";
            this.cmbEquipoDos.Size = new System.Drawing.Size(390, 23);
            this.cmbEquipoDos.TabIndex = 1;
            // 
            // btnDesafiar
            // 
            this.btnDesafiar.Location = new System.Drawing.Point(358, 53);
            this.btnDesafiar.Name = "btnDesafiar";
            this.btnDesafiar.Size = new System.Drawing.Size(156, 23);
            this.btnDesafiar.TabIndex = 2;
            this.btnDesafiar.Text = "Jugar Partido";
            this.btnDesafiar.UseVisualStyleBackColor = true;
            this.btnDesafiar.Click += new System.EventHandler(this.btnDesafiar_Click);
            // 
            // rchtDatosTorneo
            // 
            this.rchtDatosTorneo.Location = new System.Drawing.Point(12, 298);
            this.rchtDatosTorneo.Name = "rchtDatosTorneo";
            this.rchtDatosTorneo.Size = new System.Drawing.Size(840, 156);
            this.rchtDatosTorneo.TabIndex = 3;
            this.rchtDatosTorneo.Text = "";
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(12, 103);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowTemplate.Height = 25;
            this.dgvResultados.Size = new System.Drawing.Size(840, 189);
            this.dgvResultados.TabIndex = 4;
            // 
            // frmTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 455);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.rchtDatosTorneo);
            this.Controls.Add(this.btnDesafiar);
            this.Controls.Add(this.cmbEquipoDos);
            this.Controls.Add(this.cmbEquipoUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competencias";
            this.Load += new System.EventHandler(this.frmTorneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEquipoUno;
        private System.Windows.Forms.ComboBox cmbEquipoDos;
        private System.Windows.Forms.Button btnDesafiar;
        private System.Windows.Forms.RichTextBox rchtDatosTorneo;
        private System.Windows.Forms.DataGridView dgvResultados;
    }
}
