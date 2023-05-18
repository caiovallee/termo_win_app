namespace termo_win_app.Controles
{
    partial class linhaTermoUserControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            gridColunas = new TableLayoutPanel();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            gridColunas.SuspendLayout();
            SuspendLayout();
            // 
            // gridColunas
            // 
            gridColunas.ColumnCount = 5;
            gridColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            gridColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            gridColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            gridColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            gridColunas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            gridColunas.Controls.Add(lbl5, 4, 0);
            gridColunas.Controls.Add(lbl4, 3, 0);
            gridColunas.Controls.Add(lbl3, 2, 0);
            gridColunas.Controls.Add(lbl2, 1, 0);
            gridColunas.Controls.Add(lbl1, 0, 0);
            gridColunas.Dock = DockStyle.Fill;
            gridColunas.Location = new Point(0, 0);
            gridColunas.Name = "gridColunas";
            gridColunas.RowCount = 1;
            gridColunas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gridColunas.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gridColunas.Size = new Size(403, 80);
            gridColunas.TabIndex = 0;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.BackColor = SystemColors.ControlDarkDark;
            lbl5.Dock = DockStyle.Fill;
            lbl5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl5.Location = new Point(323, 3);
            lbl5.Margin = new Padding(3);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(77, 74);
            lbl5.TabIndex = 4;
            lbl5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = SystemColors.ControlDarkDark;
            lbl4.Dock = DockStyle.Fill;
            lbl4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.Location = new Point(243, 3);
            lbl4.Margin = new Padding(3);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(74, 74);
            lbl4.TabIndex = 3;
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = SystemColors.ControlDarkDark;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.Location = new Point(163, 3);
            lbl3.Margin = new Padding(3);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(74, 74);
            lbl3.TabIndex = 2;
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            lbl3.Click += lbl3_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = SystemColors.ControlDarkDark;
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.Location = new Point(83, 3);
            lbl2.Margin = new Padding(3);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(74, 74);
            lbl2.TabIndex = 1;
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.ControlDarkDark;
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(3, 3);
            lbl1.Margin = new Padding(3);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(74, 74);
            lbl1.TabIndex = 0;
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            lbl1.Click += label1_Click;
            // 
            // linhaTermoUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridColunas);
            Name = "linhaTermoUserControl";
            Size = new Size(403, 80);
            gridColunas.ResumeLayout(false);
            gridColunas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel gridColunas;
        private Label lbl1;
        private Label lbl5;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
    }
}
