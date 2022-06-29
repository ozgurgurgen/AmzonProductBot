namespace AmzBot
{
    partial class FindedItems
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
            this.UrunlerDataGrid = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maliyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatisFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdedi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agirlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UrunlerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UrunlerDataGrid
            // 
            this.UrunlerDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrunlerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UrunlerDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.UrunlerDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.UrunlerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrunlerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.ASIN,
            this.UrunAdi,
            this.Maliyet,
            this.SatisFiyat,
            this.StokAdedi,
            this.Agirlik,
            this.Rank});
            this.UrunlerDataGrid.Location = new System.Drawing.Point(12, 21);
            this.UrunlerDataGrid.Name = "UrunlerDataGrid";
            this.UrunlerDataGrid.ReadOnly = true;
            this.UrunlerDataGrid.Size = new System.Drawing.Size(776, 388);
            this.UrunlerDataGrid.TabIndex = 0;
            // 
            // SN
            // 
            this.SN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SN.FillWeight = 65.88163F;
            this.SN.HeaderText = "Sıra No";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 67;
            // 
            // ASIN
            // 
            this.ASIN.FillWeight = 97.17539F;
            this.ASIN.HeaderText = "ASIN";
            this.ASIN.Name = "ASIN";
            this.ASIN.ReadOnly = true;
            // 
            // UrunAdi
            // 
            this.UrunAdi.FillWeight = 97.17539F;
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            // 
            // Maliyet
            // 
            this.Maliyet.FillWeight = 97.17539F;
            this.Maliyet.HeaderText = "Maliyeti";
            this.Maliyet.Name = "Maliyet";
            this.Maliyet.ReadOnly = true;
            // 
            // SatisFiyat
            // 
            this.SatisFiyat.HeaderText = "Satış F.";
            this.SatisFiyat.Name = "SatisFiyat";
            this.SatisFiyat.ReadOnly = true;
            // 
            // StokAdedi
            // 
            this.StokAdedi.FillWeight = 97.17539F;
            this.StokAdedi.HeaderText = "Stok Adedi";
            this.StokAdedi.Name = "StokAdedi";
            this.StokAdedi.ReadOnly = true;
            // 
            // Agirlik
            // 
            this.Agirlik.FillWeight = 97.17539F;
            this.Agirlik.HeaderText = "Ağırlık";
            this.Agirlik.Name = "Agirlik";
            this.Agirlik.ReadOnly = true;
            // 
            // Rank
            // 
            this.Rank.FillWeight = 97.17539F;
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FindedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UrunlerDataGrid);
            this.Name = "FindedItems";
            this.Text = "FindedItems";
            ((System.ComponentModel.ISupportInitialize)(this.UrunlerDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UrunlerDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maliyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agirlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.Button button1;
    }
}