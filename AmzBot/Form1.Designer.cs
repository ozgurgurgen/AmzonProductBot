namespace AmzBot
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.botStart = new System.Windows.Forms.Button();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.SkuTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.puanNumaramatik = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minPriceNumaramatic = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.maxPriceNumaramatic = new System.Windows.Forms.NumericUpDown();
            this.yapistir = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.puanNumaramatik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceNumaramatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceNumaramatic)).BeginInit();
            this.SuspendLayout();
            // 
            // botStart
            // 
            this.botStart.Location = new System.Drawing.Point(21, 219);
            this.botStart.Name = "botStart";
            this.botStart.Size = new System.Drawing.Size(193, 28);
            this.botStart.TabIndex = 3;
            this.botStart.Text = "Botu Başlat";
            this.botStart.UseVisualStyleBackColor = true;
            this.botStart.Click += new System.EventHandler(this.botStart_Click);
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(21, 83);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(193, 20);
            this.UrlTextBox.TabIndex = 2;
            // 
            // SkuTextBox
            // 
            this.SkuTextBox.Location = new System.Drawing.Point(21, 33);
            this.SkuTextBox.Name = "SkuTextBox";
            this.SkuTextBox.Size = new System.Drawing.Size(193, 20);
            this.SkuTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SKU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amazon Linki";
            // 
            // puanNumaramatik
            // 
            this.puanNumaramatik.DecimalPlaces = 1;
            this.puanNumaramatik.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.puanNumaramatik.Location = new System.Drawing.Point(21, 130);
            this.puanNumaramatik.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.puanNumaramatik.Name = "puanNumaramatik";
            this.puanNumaramatik.Size = new System.Drawing.Size(193, 20);
            this.puanNumaramatik.TabIndex = 5;
            this.puanNumaramatik.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Minimum Ürün Puan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Min Fiyat";
            // 
            // minPriceNumaramatic
            // 
            this.minPriceNumaramatic.DecimalPlaces = 2;
            this.minPriceNumaramatic.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.minPriceNumaramatic.Location = new System.Drawing.Point(21, 178);
            this.minPriceNumaramatic.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.minPriceNumaramatic.Name = "minPriceNumaramatic";
            this.minPriceNumaramatic.Size = new System.Drawing.Size(84, 20);
            this.minPriceNumaramatic.TabIndex = 7;
            this.minPriceNumaramatic.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max Fiyat";
            // 
            // maxPriceNumaramatic
            // 
            this.maxPriceNumaramatic.DecimalPlaces = 2;
            this.maxPriceNumaramatic.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.maxPriceNumaramatic.Location = new System.Drawing.Point(130, 178);
            this.maxPriceNumaramatic.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.maxPriceNumaramatic.Name = "maxPriceNumaramatic";
            this.maxPriceNumaramatic.Size = new System.Drawing.Size(84, 20);
            this.maxPriceNumaramatic.TabIndex = 9;
            this.maxPriceNumaramatic.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // yapistir
            // 
            this.yapistir.AutoSize = true;
            this.yapistir.Location = new System.Drawing.Point(173, 67);
            this.yapistir.Name = "yapistir";
            this.yapistir.Size = new System.Drawing.Size(41, 13);
            this.yapistir.TabIndex = 11;
            this.yapistir.TabStop = true;
            this.yapistir.Text = "Yapıştır";
            this.yapistir.VisitedLinkColor = System.Drawing.Color.Blue;
            this.yapistir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.yapistir_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 268);
            this.Controls.Add(this.yapistir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxPriceNumaramatic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.minPriceNumaramatic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.puanNumaramatik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SkuTextBox);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.botStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Amz Bot V2.5";
            ((System.ComponentModel.ISupportInitialize)(this.puanNumaramatik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceNumaramatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPriceNumaramatic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botStart;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.TextBox SkuTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown puanNumaramatik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown minPriceNumaramatic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown maxPriceNumaramatic;
        private System.Windows.Forms.LinkLabel yapistir;
    }
}

