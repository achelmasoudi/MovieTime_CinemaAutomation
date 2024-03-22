namespace MovieTime.Forms
{
    partial class SatisListeleme
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisListeleme));
            this.ucretToplami = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            //this.dataSet1 = new Form1.DataSet1();
            this.satisBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.satis_BilgileriTableAdapter = new Form1.DataSet1TableAdapters.Satis_BilgileriTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tumSatislarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.satislarSilBtn = new Guna.UI2.WinForms.Guna2Button();
            this.salonComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.koltukNoTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AdSoyadTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.bilgileriGuncelleBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBilgileriBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucretToplami
            // 
            this.ucretToplami.AutoSize = true;
            this.ucretToplami.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucretToplami.ForeColor = System.Drawing.Color.Red;
            this.ucretToplami.Location = new System.Drawing.Point(155, 16);
            this.ucretToplami.Name = "ucretToplami";
            this.ucretToplami.Size = new System.Drawing.Size(47, 25);
            this.ucretToplami.TabIndex = 2;
            this.ucretToplami.Text = "0 TL";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 60;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(12, 183);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 35;
            this.guna2DataGridView1.Size = new System.Drawing.Size(985, 369);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 60;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.guna2DataGridView1_CellMouseClick);
            
            this.satisBilgileriBindingSource.DataMember = "Satis_Bilgileri";
          
            // 
            //this.satis_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 92;
            this.label4.Text = "Film tarihe göre Listele";
            // 
            // tumSatislarBtn
            // 
            this.tumSatislarBtn.BackColor = System.Drawing.Color.Transparent;
            this.tumSatislarBtn.BorderColor = System.Drawing.Color.White;
            this.tumSatislarBtn.BorderRadius = 5;
            this.tumSatislarBtn.BorderThickness = 1;
            this.tumSatislarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tumSatislarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tumSatislarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tumSatislarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tumSatislarBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.tumSatislarBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.tumSatislarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.tumSatislarBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.tumSatislarBtn.ImageOffset = new System.Drawing.Point(0, 2);
            this.tumSatislarBtn.ImageSize = new System.Drawing.Size(21, 21);
            this.tumSatislarBtn.Location = new System.Drawing.Point(373, 569);
            this.tumSatislarBtn.Name = "tumSatislarBtn";
            this.tumSatislarBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(56)))), ((int)(((byte)(216)))));
            this.tumSatislarBtn.PressedDepth = 80;
            this.tumSatislarBtn.Size = new System.Drawing.Size(260, 44);
            this.tumSatislarBtn.TabIndex = 93;
            this.tumSatislarBtn.Text = "Tüm Satışlar";
            this.tumSatislarBtn.Click += new System.EventHandler(this.tumSatislarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Toplam Fiyat :";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.ucretToplami);
            this.guna2Panel1.Location = new System.Drawing.Point(735, 563);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(262, 57);
            this.guna2Panel1.TabIndex = 95;
            // 
            // satislarSilBtn
            // 
            this.satislarSilBtn.BackColor = System.Drawing.Color.Transparent;
            this.satislarSilBtn.BorderColor = System.Drawing.Color.White;
            this.satislarSilBtn.BorderRadius = 5;
            this.satislarSilBtn.BorderThickness = 1;
            this.satislarSilBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.satislarSilBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.satislarSilBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.satislarSilBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.satislarSilBtn.FillColor = System.Drawing.Color.Red;
            this.satislarSilBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satislarSilBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.satislarSilBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.satislarSilBtn.Location = new System.Drawing.Point(810, 25);
            this.satislarSilBtn.Name = "satislarSilBtn";
            this.satislarSilBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.satislarSilBtn.PressedDepth = 60;
            this.satislarSilBtn.Size = new System.Drawing.Size(187, 45);
            this.satislarSilBtn.TabIndex = 96;
            this.satislarSilBtn.Text = "Tarihe göre Satışlar Sil";
            this.satislarSilBtn.Click += new System.EventHandler(this.satislarSilBtn_Click);
            // 
            // salonComB
            // 
            this.salonComB.BackColor = System.Drawing.Color.Transparent;
            this.salonComB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.salonComB.BorderRadius = 5;
            this.salonComB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.salonComB.DropDownHeight = 160;
            this.salonComB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.salonComB.DropDownWidth = 190;
            this.salonComB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.salonComB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.salonComB.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.salonComB.ForeColor = System.Drawing.Color.Black;
            this.salonComB.IntegralHeight = false;
            this.salonComB.ItemHeight = 28;
            this.salonComB.Location = new System.Drawing.Point(380, 36);
            this.salonComB.Name = "salonComB";
            this.salonComB.Size = new System.Drawing.Size(236, 34);
            this.salonComB.TabIndex = 101;
            this.salonComB.SelectedIndexChanged += new System.EventHandler(this.salonComB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(377, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 100;
            this.label2.Text = "Salon Adına göre listeleme";
            // 
            // koltukNoTxtB
            // 
            this.koltukNoTxtB.BackColor = System.Drawing.Color.Transparent;
            this.koltukNoTxtB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.koltukNoTxtB.BorderRadius = 5;
            this.koltukNoTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.koltukNoTxtB.DefaultText = "";
            this.koltukNoTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.koltukNoTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.koltukNoTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.koltukNoTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.koltukNoTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(56)))), ((int)(((byte)(216)))));
            this.koltukNoTxtB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.koltukNoTxtB.ForeColor = System.Drawing.Color.Black;
            this.koltukNoTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.koltukNoTxtB.IconLeft = ((System.Drawing.Image)(resources.GetObject("koltukNoTxtB.IconLeft")));
            this.koltukNoTxtB.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.koltukNoTxtB.IconLeftSize = new System.Drawing.Size(18, 18);
            this.koltukNoTxtB.Location = new System.Drawing.Point(15, 111);
            this.koltukNoTxtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.koltukNoTxtB.Name = "koltukNoTxtB";
            this.koltukNoTxtB.PasswordChar = '\0';
            this.koltukNoTxtB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.koltukNoTxtB.PlaceholderText = "Koltuk_No şeklinde giriniz";
            this.koltukNoTxtB.SelectedText = "";
            this.koltukNoTxtB.Size = new System.Drawing.Size(206, 34);
            this.koltukNoTxtB.TabIndex = 103;
            this.koltukNoTxtB.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(14, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 102;
            this.label5.Text = "Koltuk No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(379, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 105;
            this.label6.Text = "Ad Soyad";
            // 
            // AdSoyadTxtB
            // 
            this.AdSoyadTxtB.BackColor = System.Drawing.Color.Transparent;
            this.AdSoyadTxtB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.AdSoyadTxtB.BorderRadius = 5;
            this.AdSoyadTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdSoyadTxtB.DefaultText = "";
            this.AdSoyadTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AdSoyadTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AdSoyadTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdSoyadTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AdSoyadTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(56)))), ((int)(((byte)(216)))));
            this.AdSoyadTxtB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdSoyadTxtB.ForeColor = System.Drawing.Color.Black;
            this.AdSoyadTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.AdSoyadTxtB.IconLeft = ((System.Drawing.Image)(resources.GetObject("AdSoyadTxtB.IconLeft")));
            this.AdSoyadTxtB.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.AdSoyadTxtB.IconLeftSize = new System.Drawing.Size(18, 18);
            this.AdSoyadTxtB.Location = new System.Drawing.Point(382, 111);
            this.AdSoyadTxtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdSoyadTxtB.Name = "AdSoyadTxtB";
            this.AdSoyadTxtB.PasswordChar = '\0';
            this.AdSoyadTxtB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.AdSoyadTxtB.PlaceholderText = "";
            this.AdSoyadTxtB.SelectedText = "";
            this.AdSoyadTxtB.Size = new System.Drawing.Size(237, 34);
            this.AdSoyadTxtB.TabIndex = 104;
            this.AdSoyadTxtB.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // bilgileriGuncelleBtn
            // 
            this.bilgileriGuncelleBtn.BackColor = System.Drawing.Color.Transparent;
            this.bilgileriGuncelleBtn.BorderColor = System.Drawing.Color.White;
            this.bilgileriGuncelleBtn.BorderRadius = 5;
            this.bilgileriGuncelleBtn.BorderThickness = 1;
            this.bilgileriGuncelleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bilgileriGuncelleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bilgileriGuncelleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bilgileriGuncelleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bilgileriGuncelleBtn.FillColor = System.Drawing.Color.Blue;
            this.bilgileriGuncelleBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.bilgileriGuncelleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.bilgileriGuncelleBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.bilgileriGuncelleBtn.Location = new System.Drawing.Point(810, 106);
            this.bilgileriGuncelleBtn.Name = "bilgileriGuncelleBtn";
            this.bilgileriGuncelleBtn.PressedColor = System.Drawing.Color.DarkBlue;
            this.bilgileriGuncelleBtn.PressedDepth = 60;
            this.bilgileriGuncelleBtn.Size = new System.Drawing.Size(187, 45);
            this.bilgileriGuncelleBtn.TabIndex = 108;
            this.bilgileriGuncelleBtn.Text = "Bilgileri Güncelle";
            this.bilgileriGuncelleBtn.Click += new System.EventHandler(this.bilgileriGuncelleBtn_Click);
            // 
            // SatisListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1009, 627);
            this.Controls.Add(this.bilgileriGuncelleBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AdSoyadTxtB);
            this.Controls.Add(this.koltukNoTxtB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salonComB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.satislarSilBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.tumSatislarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.guna2DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SatisListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatilanBiletler";
            this.Load += new System.EventHandler(this.SatisListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBilgileriBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ucretToplami;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        //private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource satisBilgileriBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button tumSatislarBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button satislarSilBtn;
        private Guna.UI2.WinForms.Guna2ComboBox salonComB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox koltukNoTxtB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox AdSoyadTxtB;
        private Guna.UI2.WinForms.Guna2Button bilgileriGuncelleBtn;
    }
}