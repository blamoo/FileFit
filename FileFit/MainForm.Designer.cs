namespace FileFit
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ClusterGbx = new System.Windows.Forms.GroupBox();
            this.ClusterTxt = new System.Windows.Forms.TextBox();
            this.TamanhoGbx = new System.Windows.Forms.GroupBox();
            this.TamanhoTxt = new System.Windows.Forms.TextBox();
            this.FilesGbx = new System.Windows.Forms.GroupBox();
            this.LimparBtn = new System.Windows.Forms.Button();
            this.AddDirRecBtn = new System.Windows.Forms.Button();
            this.FilesLst = new System.Windows.Forms.ListView();
            this.NameItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullPathItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CalcularBtn = new System.Windows.Forms.Button();
            this.ResultadoLst = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ClusterGbx.SuspendLayout();
            this.TamanhoGbx.SuspendLayout();
            this.FilesGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ClusterGbx);
            this.splitContainer1.Panel1.Controls.Add(this.TamanhoGbx);
            this.splitContainer1.Panel1.Controls.Add(this.FilesGbx);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CalcularBtn);
            this.splitContainer1.Panel2.Controls.Add(this.ResultadoLst);
            this.splitContainer1.Size = new System.Drawing.Size(733, 422);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 1;
            // 
            // ClusterGbx
            // 
            this.ClusterGbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClusterGbx.Controls.Add(this.ClusterTxt);
            this.ClusterGbx.Location = new System.Drawing.Point(163, 371);
            this.ClusterGbx.Name = "ClusterGbx";
            this.ClusterGbx.Size = new System.Drawing.Size(122, 45);
            this.ClusterGbx.TabIndex = 2;
            this.ClusterGbx.TabStop = false;
            this.ClusterGbx.Text = "Tamanho do cluster";
            // 
            // ClusterTxt
            // 
            this.ClusterTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClusterTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FileFit.Properties.Settings.Default, "Cluster", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClusterTxt.Location = new System.Drawing.Point(6, 17);
            this.ClusterTxt.Name = "ClusterTxt";
            this.ClusterTxt.Size = new System.Drawing.Size(110, 20);
            this.ClusterTxt.TabIndex = 0;
            this.ClusterTxt.Text = global::FileFit.Properties.Settings.Default.Cluster;
            // 
            // TamanhoGbx
            // 
            this.TamanhoGbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TamanhoGbx.Controls.Add(this.TamanhoTxt);
            this.TamanhoGbx.Location = new System.Drawing.Point(3, 371);
            this.TamanhoGbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TamanhoGbx.Name = "TamanhoGbx";
            this.TamanhoGbx.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TamanhoGbx.Size = new System.Drawing.Size(154, 45);
            this.TamanhoGbx.TabIndex = 0;
            this.TamanhoGbx.TabStop = false;
            this.TamanhoGbx.Text = "Tamanho (em bytes)";
            // 
            // TamanhoTxt
            // 
            this.TamanhoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TamanhoTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FileFit.Properties.Settings.Default, "Size", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TamanhoTxt.Location = new System.Drawing.Point(7, 17);
            this.TamanhoTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TamanhoTxt.Name = "TamanhoTxt";
            this.TamanhoTxt.Size = new System.Drawing.Size(141, 20);
            this.TamanhoTxt.TabIndex = 0;
            this.TamanhoTxt.Text = global::FileFit.Properties.Settings.Default.Size;
            // 
            // FilesGbx
            // 
            this.FilesGbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesGbx.Controls.Add(this.LimparBtn);
            this.FilesGbx.Controls.Add(this.AddDirRecBtn);
            this.FilesGbx.Controls.Add(this.FilesLst);
            this.FilesGbx.Location = new System.Drawing.Point(3, 2);
            this.FilesGbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilesGbx.Name = "FilesGbx";
            this.FilesGbx.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilesGbx.Size = new System.Drawing.Size(282, 364);
            this.FilesGbx.TabIndex = 1;
            this.FilesGbx.TabStop = false;
            this.FilesGbx.Text = "Arquivos / Pastas";
            // 
            // LimparBtn
            // 
            this.LimparBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LimparBtn.Location = new System.Drawing.Point(7, 336);
            this.LimparBtn.Name = "LimparBtn";
            this.LimparBtn.Size = new System.Drawing.Size(52, 23);
            this.LimparBtn.TabIndex = 1;
            this.LimparBtn.Text = "Limpar";
            this.LimparBtn.UseVisualStyleBackColor = true;
            this.LimparBtn.Click += new System.EventHandler(this.LimparBtn_Click);
            // 
            // AddDirRecBtn
            // 
            this.AddDirRecBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDirRecBtn.Location = new System.Drawing.Point(175, 335);
            this.AddDirRecBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDirRecBtn.Name = "AddDirRecBtn";
            this.AddDirRecBtn.Size = new System.Drawing.Size(101, 24);
            this.AddDirRecBtn.TabIndex = 0;
            this.AddDirRecBtn.Text = "Arquivos e Pastas";
            this.AddDirRecBtn.UseVisualStyleBackColor = true;
            this.AddDirRecBtn.Click += new System.EventHandler(this.AddDirRecBtn_Click);
            // 
            // FilesLst
            // 
            this.FilesLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameItem,
            this.SizeItem,
            this.FullPathItem});
            this.FilesLst.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.FilesLst.FullRowSelect = true;
            this.FilesLst.Location = new System.Drawing.Point(7, 17);
            this.FilesLst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilesLst.Name = "FilesLst";
            this.FilesLst.Size = new System.Drawing.Size(269, 314);
            this.FilesLst.TabIndex = 0;
            this.FilesLst.UseCompatibleStateImageBehavior = false;
            this.FilesLst.View = System.Windows.Forms.View.Details;
            // 
            // NameItem
            // 
            this.NameItem.Text = "Nome";
            this.NameItem.Width = 130;
            // 
            // SizeItem
            // 
            this.SizeItem.Text = "Tamanho";
            this.SizeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SizeItem.Width = 83;
            // 
            // FullPathItem
            // 
            this.FullPathItem.Text = "Caminho completo";
            // 
            // CalcularBtn
            // 
            this.CalcularBtn.Location = new System.Drawing.Point(3, 2);
            this.CalcularBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalcularBtn.Name = "CalcularBtn";
            this.CalcularBtn.Size = new System.Drawing.Size(75, 24);
            this.CalcularBtn.TabIndex = 1;
            this.CalcularBtn.Text = "Calcular";
            this.CalcularBtn.UseVisualStyleBackColor = true;
            this.CalcularBtn.Click += new System.EventHandler(this.CalcularBtn_Click);
            // 
            // ResultadoLst
            // 
            this.ResultadoLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultadoLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ResultadoLst.FullRowSelect = true;
            this.ResultadoLst.Location = new System.Drawing.Point(3, 30);
            this.ResultadoLst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResultadoLst.MultiSelect = false;
            this.ResultadoLst.Name = "ResultadoLst";
            this.ResultadoLst.Size = new System.Drawing.Size(425, 386);
            this.ResultadoLst.TabIndex = 0;
            this.ResultadoLst.UseCompatibleStateImageBehavior = false;
            this.ResultadoLst.View = System.Windows.Forms.View.Details;
            this.ResultadoLst.DoubleClick += new System.EventHandler(this.ResultadoLst_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tamanho";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Porcentagem";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 167;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 422);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(550, 241);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ClusterGbx.ResumeLayout(false);
            this.ClusterGbx.PerformLayout();
            this.TamanhoGbx.ResumeLayout(false);
            this.TamanhoGbx.PerformLayout();
            this.FilesGbx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox TamanhoGbx;
        private System.Windows.Forms.TextBox TamanhoTxt;
        private System.Windows.Forms.GroupBox FilesGbx;
        private System.Windows.Forms.Button AddDirRecBtn;
        private System.Windows.Forms.ListView FilesLst;
        private System.Windows.Forms.ColumnHeader NameItem;
        private System.Windows.Forms.ColumnHeader SizeItem;
        private System.Windows.Forms.ColumnHeader FullPathItem;
        private System.Windows.Forms.Button CalcularBtn;
        private System.Windows.Forms.ListView ResultadoLst;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button LimparBtn;
        private System.Windows.Forms.GroupBox ClusterGbx;
        private System.Windows.Forms.TextBox ClusterTxt;
    }
}