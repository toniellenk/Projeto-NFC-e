﻿namespace Projeto_NFC_e
{
    partial class FormPesquisaSimples
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LsVyPrinc = new System.Windows.Forms.DataGridView();
            this.PanFiltros = new System.Windows.Forms.Panel();
            this.TxtBoxProcurar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadButContendo = new System.Windows.Forms.RadioButton();
            this.RadButIgual = new System.Windows.Forms.RadioButton();
            this.ButProcurar = new System.Windows.Forms.Button();
            this.CombBxFilt = new System.Windows.Forms.ComboBox();
            this.ButNovo = new System.Windows.Forms.Button();
            this.ButExcluir = new System.Windows.Forms.Button();
            this.ButAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LsVyPrinc)).BeginInit();
            this.PanFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LsVyPrinc
            // 
            this.LsVyPrinc.AllowUserToAddRows = false;
            this.LsVyPrinc.AllowUserToDeleteRows = false;
            this.LsVyPrinc.AllowUserToResizeColumns = false;
            this.LsVyPrinc.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LsVyPrinc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.LsVyPrinc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LsVyPrinc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LsVyPrinc.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.LsVyPrinc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LsVyPrinc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LsVyPrinc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.LsVyPrinc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LsVyPrinc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.LsVyPrinc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LsVyPrinc.DefaultCellStyle = dataGridViewCellStyle7;
            this.LsVyPrinc.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.LsVyPrinc.GridColor = System.Drawing.Color.Aqua;
            this.LsVyPrinc.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.LsVyPrinc.Location = new System.Drawing.Point(0, 99);
            this.LsVyPrinc.Margin = new System.Windows.Forms.Padding(5);
            this.LsVyPrinc.MultiSelect = false;
            this.LsVyPrinc.Name = "LsVyPrinc";
            this.LsVyPrinc.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LsVyPrinc.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.LsVyPrinc.RowHeadersVisible = false;
            this.LsVyPrinc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LsVyPrinc.Size = new System.Drawing.Size(611, 208);
            this.LsVyPrinc.StandardTab = true;
            this.LsVyPrinc.TabIndex = 3;
            // 
            // PanFiltros
            // 
            this.PanFiltros.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PanFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanFiltros.Controls.Add(this.TxtBoxProcurar);
            this.PanFiltros.Controls.Add(this.groupBox1);
            this.PanFiltros.Controls.Add(this.ButProcurar);
            this.PanFiltros.Controls.Add(this.CombBxFilt);
            this.PanFiltros.Location = new System.Drawing.Point(0, 10);
            this.PanFiltros.Name = "PanFiltros";
            this.PanFiltros.Size = new System.Drawing.Size(611, 77);
            this.PanFiltros.TabIndex = 6;
            this.PanFiltros.Paint += new System.Windows.Forms.PaintEventHandler(this.PanFiltros_Paint);
            // 
            // TxtBoxProcurar
            // 
            this.TxtBoxProcurar.Location = new System.Drawing.Point(320, 26);
            this.TxtBoxProcurar.Name = "TxtBoxProcurar";
            this.TxtBoxProcurar.Size = new System.Drawing.Size(182, 20);
            this.TxtBoxProcurar.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadButContendo);
            this.groupBox1.Controls.Add(this.RadButIgual);
            this.groupBox1.Location = new System.Drawing.Point(147, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 39);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campo";
            // 
            // RadButContendo
            // 
            this.RadButContendo.AutoSize = true;
            this.RadButContendo.Location = new System.Drawing.Point(80, 16);
            this.RadButContendo.Name = "RadButContendo";
            this.RadButContendo.Size = new System.Drawing.Size(71, 17);
            this.RadButContendo.TabIndex = 8;
            this.RadButContendo.TabStop = true;
            this.RadButContendo.Text = "Contendo";
            this.RadButContendo.UseVisualStyleBackColor = true;
            // 
            // RadButIgual
            // 
            this.RadButIgual.AutoSize = true;
            this.RadButIgual.Location = new System.Drawing.Point(14, 16);
            this.RadButIgual.Name = "RadButIgual";
            this.RadButIgual.Size = new System.Drawing.Size(48, 17);
            this.RadButIgual.TabIndex = 0;
            this.RadButIgual.TabStop = true;
            this.RadButIgual.Text = "Igual";
            this.RadButIgual.UseVisualStyleBackColor = true;
            this.RadButIgual.CheckedChanged += new System.EventHandler(this.RadButIgual_CheckedChanged);
            // 
            // ButProcurar
            // 
            this.ButProcurar.Location = new System.Drawing.Point(521, 24);
            this.ButProcurar.Name = "ButProcurar";
            this.ButProcurar.Size = new System.Drawing.Size(75, 23);
            this.ButProcurar.TabIndex = 1;
            this.ButProcurar.Text = "Procurar";
            this.ButProcurar.UseVisualStyleBackColor = true;
            this.ButProcurar.Click += new System.EventHandler(this.ButProcurar_Click);
            // 
            // CombBxFilt
            // 
            this.CombBxFilt.FormattingEnabled = true;
            this.CombBxFilt.Location = new System.Drawing.Point(10, 26);
            this.CombBxFilt.Name = "CombBxFilt";
            this.CombBxFilt.Size = new System.Drawing.Size(131, 21);
            this.CombBxFilt.TabIndex = 0;
            this.CombBxFilt.SelectedIndexChanged += new System.EventHandler(this.CombBxFilt_SelectedIndexChanged);
            // 
            // ButNovo
            // 
            this.ButNovo.Location = new System.Drawing.Point(12, 321);
            this.ButNovo.Name = "ButNovo";
            this.ButNovo.Size = new System.Drawing.Size(75, 26);
            this.ButNovo.TabIndex = 7;
            this.ButNovo.Text = "Novo";
            this.ButNovo.UseVisualStyleBackColor = true;
            // 
            // ButExcluir
            // 
            this.ButExcluir.Location = new System.Drawing.Point(225, 321);
            this.ButExcluir.Name = "ButExcluir";
            this.ButExcluir.Size = new System.Drawing.Size(75, 26);
            this.ButExcluir.TabIndex = 9;
            this.ButExcluir.Text = "Excluir";
            this.ButExcluir.UseVisualStyleBackColor = true;
            // 
            // ButAlterar
            // 
            this.ButAlterar.Location = new System.Drawing.Point(120, 321);
            this.ButAlterar.Name = "ButAlterar";
            this.ButAlterar.Size = new System.Drawing.Size(75, 26);
            this.ButAlterar.TabIndex = 8;
            this.ButAlterar.Text = "Alterar";
            this.ButAlterar.UseVisualStyleBackColor = true;
            // 
            // FormPesquisaSimples
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 359);
            this.Controls.Add(this.ButNovo);
            this.Controls.Add(this.ButExcluir);
            this.Controls.Add(this.ButAlterar);
            this.Controls.Add(this.PanFiltros);
            this.Controls.Add(this.LsVyPrinc);
            this.MinimizeBox = false;
            this.Name = "FormPesquisaSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa Simples";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormPesquisaSimples_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LsVyPrinc)).EndInit();
            this.PanFiltros.ResumeLayout(false);
            this.PanFiltros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LsVyPrinc;
        private System.Windows.Forms.Panel PanFiltros;
        private System.Windows.Forms.TextBox TxtBoxProcurar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadButContendo;
        private System.Windows.Forms.RadioButton RadButIgual;
        private System.Windows.Forms.Button ButProcurar;
        private System.Windows.Forms.ComboBox CombBxFilt;
        private System.Windows.Forms.Button ButNovo;
        private System.Windows.Forms.Button ButExcluir;
        private System.Windows.Forms.Button ButAlterar;
    }
}