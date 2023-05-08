namespace kimlikk_uygulamasi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnfotoekle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtcinsiyet = new System.Windows.Forms.TextBox();
            this.txtdogumtarihi = new System.Windows.Forms.TextBox();
            this.txtdogumyeri = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumtarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumyeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kimlikkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kimlik_kartiiDataSet1 = new kimlikk_uygulamasi.kimlik_kartiiDataSet1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtfotograf = new System.Windows.Forms.TextBox();
            this.kimlikkTableAdapter = new kimlikk_uygulamasi.kimlik_kartiiDataSet1TableAdapters.kimlikkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimlikkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimlik_kartiiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "tcno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "cinsiyet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "dogum tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "dogum yeri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "fotograf";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnfotoekle
            // 
            this.btnfotoekle.Location = new System.Drawing.Point(273, 231);
            this.btnfotoekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnfotoekle.Name = "btnfotoekle";
            this.btnfotoekle.Size = new System.Drawing.Size(100, 28);
            this.btnfotoekle.TabIndex = 7;
            this.btnfotoekle.Text = "fotograf ekle";
            this.btnfotoekle.UseVisualStyleBackColor = true;
            this.btnfotoekle.Click += new System.EventHandler(this.btnfotoekle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(381, 231);
            this.btnekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(100, 28);
            this.btnekle.TabIndex = 8;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(489, 231);
            this.btnguncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(100, 28);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(597, 231);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(100, 28);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(107, 15);
            this.txttc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(132, 22);
            this.txttc.TabIndex = 11;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(107, 47);
            this.txtad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(132, 22);
            this.txtad.TabIndex = 12;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(107, 79);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(132, 22);
            this.txtsoyad.TabIndex = 13;
            // 
            // txtcinsiyet
            // 
            this.txtcinsiyet.Location = new System.Drawing.Point(107, 111);
            this.txtcinsiyet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcinsiyet.Name = "txtcinsiyet";
            this.txtcinsiyet.Size = new System.Drawing.Size(132, 22);
            this.txtcinsiyet.TabIndex = 14;
            // 
            // txtdogumtarihi
            // 
            this.txtdogumtarihi.Location = new System.Drawing.Point(107, 143);
            this.txtdogumtarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdogumtarihi.Name = "txtdogumtarihi";
            this.txtdogumtarihi.Size = new System.Drawing.Size(132, 22);
            this.txtdogumtarihi.TabIndex = 15;
            // 
            // txtdogumyeri
            // 
            this.txtdogumyeri.Location = new System.Drawing.Point(107, 175);
            this.txtdogumyeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdogumyeri.Name = "txtdogumyeri";
            this.txtdogumyeri.Size = new System.Drawing.Size(132, 22);
            this.txtdogumyeri.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcnoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.dogumtarihiDataGridViewTextBoxColumn,
            this.dogumyeriDataGridViewTextBoxColumn,
            this.fotografDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kimlikkBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(273, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(991, 185);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tcnoDataGridViewTextBoxColumn
            // 
            this.tcnoDataGridViewTextBoxColumn.DataPropertyName = "tc_no";
            this.tcnoDataGridViewTextBoxColumn.HeaderText = "tc_no";
            this.tcnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tcnoDataGridViewTextBoxColumn.Name = "tcnoDataGridViewTextBoxColumn";
            this.tcnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumtarihiDataGridViewTextBoxColumn
            // 
            this.dogumtarihiDataGridViewTextBoxColumn.DataPropertyName = "dogumtarihi";
            this.dogumtarihiDataGridViewTextBoxColumn.HeaderText = "dogumtarihi";
            this.dogumtarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumtarihiDataGridViewTextBoxColumn.Name = "dogumtarihiDataGridViewTextBoxColumn";
            this.dogumtarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumyeriDataGridViewTextBoxColumn
            // 
            this.dogumyeriDataGridViewTextBoxColumn.DataPropertyName = "dogumyeri";
            this.dogumyeriDataGridViewTextBoxColumn.HeaderText = "dogumyeri";
            this.dogumyeriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumyeriDataGridViewTextBoxColumn.Name = "dogumyeriDataGridViewTextBoxColumn";
            this.dogumyeriDataGridViewTextBoxColumn.Width = 125;
            // 
            // fotografDataGridViewTextBoxColumn
            // 
            this.fotografDataGridViewTextBoxColumn.DataPropertyName = "fotograf";
            this.fotografDataGridViewTextBoxColumn.HeaderText = "fotograf";
            this.fotografDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fotografDataGridViewTextBoxColumn.Name = "fotografDataGridViewTextBoxColumn";
            this.fotografDataGridViewTextBoxColumn.Width = 125;
            // 
            // kimlikkBindingSource
            // 
            this.kimlikkBindingSource.DataMember = "kimlikk";
            this.kimlikkBindingSource.DataSource = this.kimlik_kartiiDataSet1;
            // 
            // kimlik_kartiiDataSet1
            // 
            this.kimlik_kartiiDataSet1.DataSetName = "kimlik_kartiiDataSet1";
            this.kimlik_kartiiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 220);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtfotograf
            // 
            this.txtfotograf.Location = new System.Drawing.Point(273, 267);
            this.txtfotograf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfotograf.Name = "txtfotograf";
            this.txtfotograf.Size = new System.Drawing.Size(207, 22);
            this.txtfotograf.TabIndex = 19;
            // 
            // kimlikkTableAdapter
            // 
            this.kimlikkTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 375);
            this.Controls.Add(this.txtfotograf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtdogumyeri);
            this.Controls.Add(this.txtdogumtarihi);
            this.Controls.Add(this.txtcinsiyet);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnfotoekle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimlikkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kimlik_kartiiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnfotoekle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtcinsiyet;
        private System.Windows.Forms.TextBox txtdogumtarihi;
        private System.Windows.Forms.TextBox txtdogumyeri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtfotograf;
        private kimlik_kartiiDataSet1 kimlik_kartiiDataSet1;
        private System.Windows.Forms.BindingSource kimlikkBindingSource;
        private kimlik_kartiiDataSet1TableAdapters.kimlikkTableAdapter kimlikkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumtarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumyeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotografDataGridViewTextBoxColumn;
    }
}

