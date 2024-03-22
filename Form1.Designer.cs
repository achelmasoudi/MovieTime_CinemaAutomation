namespace MovieTime
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.offPanel = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new global::MovieTime.GradientPanel();
            this.SilGuncelleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.seansEkleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.satisListelemeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.minimizeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.biletSatBtn = new Guna.UI2.WinForms.Guna2Button();
            this.filmEkleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.sideBar = new Guna.UI2.WinForms.Guna2Button();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // offPanel
            // 
            this.offPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offPanel.Location = new System.Drawing.Point(213, 0);
            this.offPanel.Name = "offPanel";
            this.offPanel.Size = new System.Drawing.Size(1009, 627);
            this.offPanel.TabIndex = 1;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(56)))), ((int)(((byte)(216)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.gradientPanel1.Controls.Add(this.SilGuncelleBtn);
            this.gradientPanel1.Controls.Add(this.seansEkleBtn);
            this.gradientPanel1.Controls.Add(this.satisListelemeBtn);
            this.gradientPanel1.Controls.Add(this.minimizeBtn);
            this.gradientPanel1.Controls.Add(this.closeBtn);
            this.gradientPanel1.Controls.Add(this.biletSatBtn);
            this.gradientPanel1.Controls.Add(this.filmEkleBtn);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.HomeBtn);
            this.gradientPanel1.Controls.Add(this.sideBar);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(213, 627);
            this.gradientPanel1.TabIndex = 0;
            // 
            // SilGuncelleBtn
            // 
            this.SilGuncelleBtn.BackColor = System.Drawing.Color.Transparent;
            this.SilGuncelleBtn.BorderColor = System.Drawing.Color.White;
            this.SilGuncelleBtn.BorderRadius = 5;
            this.SilGuncelleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SilGuncelleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SilGuncelleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SilGuncelleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SilGuncelleBtn.FillColor = System.Drawing.Color.Transparent;
            this.SilGuncelleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilGuncelleBtn.ForeColor = System.Drawing.Color.LightGray;
            this.SilGuncelleBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.SilGuncelleBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.SilGuncelleBtn.HoverState.Image = global::MovieTime.Properties.Resources.selectedDeleteMovie;
            this.SilGuncelleBtn.Image = global::MovieTime.Properties.Resources.unselectedDeleteMovie;
            this.SilGuncelleBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SilGuncelleBtn.ImageOffset = new System.Drawing.Point(16, 0);
            this.SilGuncelleBtn.ImageSize = new System.Drawing.Size(21, 21);
            this.SilGuncelleBtn.Location = new System.Drawing.Point(6, 400);
            this.SilGuncelleBtn.Name = "SilGuncelleBtn";
            this.SilGuncelleBtn.Size = new System.Drawing.Size(207, 33);
            this.SilGuncelleBtn.TabIndex = 12;
            this.SilGuncelleBtn.Text = " Sil veya Güncelle";
            this.SilGuncelleBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SilGuncelleBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.SilGuncelleBtn.Click += new System.EventHandler(this.filmSilGuncelleBtn_Click);
            // 
            // seansEkleBtn
            // 
            this.seansEkleBtn.BackColor = System.Drawing.Color.Transparent;
            this.seansEkleBtn.BorderColor = System.Drawing.Color.White;
            this.seansEkleBtn.BorderRadius = 5;
            this.seansEkleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.seansEkleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.seansEkleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.seansEkleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.seansEkleBtn.FillColor = System.Drawing.Color.Transparent;
            this.seansEkleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seansEkleBtn.ForeColor = System.Drawing.Color.LightGray;
            this.seansEkleBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.seansEkleBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.seansEkleBtn.HoverState.Image = global::MovieTime.Properties.Resources.selectedSeansEkle;
            this.seansEkleBtn.Image = global::MovieTime.Properties.Resources.unselectedSeansEkle;
            this.seansEkleBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.seansEkleBtn.ImageOffset = new System.Drawing.Point(16, 0);
            this.seansEkleBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.seansEkleBtn.Location = new System.Drawing.Point(6, 241);
            this.seansEkleBtn.Name = "seansEkleBtn";
            this.seansEkleBtn.Size = new System.Drawing.Size(207, 33);
            this.seansEkleBtn.TabIndex = 11;
            this.seansEkleBtn.Text = " Seans Ekle";
            this.seansEkleBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.seansEkleBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.seansEkleBtn.Click += new System.EventHandler(this.seansEkleBtn_Click);
            // 
            // satisListelemeBtn
            // 
            this.satisListelemeBtn.BackColor = System.Drawing.Color.Transparent;
            this.satisListelemeBtn.BorderColor = System.Drawing.Color.White;
            this.satisListelemeBtn.BorderRadius = 5;
            this.satisListelemeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.satisListelemeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.satisListelemeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.satisListelemeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.satisListelemeBtn.FillColor = System.Drawing.Color.Transparent;
            this.satisListelemeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satisListelemeBtn.ForeColor = System.Drawing.Color.LightGray;
            this.satisListelemeBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.satisListelemeBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.satisListelemeBtn.HoverState.Image = global::MovieTime.Properties.Resources.selectedSatisListeleme;
            this.satisListelemeBtn.Image = global::MovieTime.Properties.Resources.unselectedSatisListeleme;
            this.satisListelemeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.satisListelemeBtn.ImageOffset = new System.Drawing.Point(16, 0);
            this.satisListelemeBtn.ImageSize = new System.Drawing.Size(23, 23);
            this.satisListelemeBtn.Location = new System.Drawing.Point(6, 347);
            this.satisListelemeBtn.Name = "satisListelemeBtn";
            this.satisListelemeBtn.Size = new System.Drawing.Size(207, 33);
            this.satisListelemeBtn.TabIndex = 10;
            this.satisListelemeBtn.Text = " Satış Listeleme";
            this.satisListelemeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.satisListelemeBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.satisListelemeBtn.Click += new System.EventHandler(this.satisListelemeBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.minimizeBtn.HoverState.Image = global::MovieTime.Properties.Resources.selectedMinimize;
            this.minimizeBtn.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.minimizeBtn.Image = global::MovieTime.Properties.Resources.unselectedMinimize;
            this.minimizeBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.minimizeBtn.ImageRotate = 0F;
            this.minimizeBtn.ImageSize = new System.Drawing.Size(23, 23);
            this.minimizeBtn.Location = new System.Drawing.Point(40, 10);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.PressedState.Image = global::MovieTime.Properties.Resources.selectedMinimize;
            this.minimizeBtn.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.minimizeBtn.Size = new System.Drawing.Size(24, 24);
            this.minimizeBtn.TabIndex = 9;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeBtn.HoverState.Image = global::MovieTime.Properties.Resources.selectedClose;
            this.closeBtn.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.closeBtn.Image = global::MovieTime.Properties.Resources.unselectedClose;
            this.closeBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.closeBtn.ImageRotate = 0F;
            this.closeBtn.ImageSize = new System.Drawing.Size(23, 23);
            this.closeBtn.Location = new System.Drawing.Point(13, 10);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.PressedState.Image = global::MovieTime.Properties.Resources.selectedClose;
            this.closeBtn.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.closeBtn.Size = new System.Drawing.Size(24, 24);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // biletSatBtn
            // 
            this.biletSatBtn.BackColor = System.Drawing.Color.Transparent;
            this.biletSatBtn.BorderColor = System.Drawing.Color.White;
            this.biletSatBtn.BorderRadius = 5;
            this.biletSatBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.biletSatBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.biletSatBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.biletSatBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.biletSatBtn.FillColor = System.Drawing.Color.Transparent;
            this.biletSatBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biletSatBtn.ForeColor = System.Drawing.Color.LightGray;
            this.biletSatBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.biletSatBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.biletSatBtn.HoverState.Image = global::MovieTime.Properties.Resources.selectedBilet;
            this.biletSatBtn.Image = global::MovieTime.Properties.Resources.unselectedBilet;
            this.biletSatBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.biletSatBtn.ImageOffset = new System.Drawing.Point(16, 0);
            this.biletSatBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.biletSatBtn.Location = new System.Drawing.Point(6, 294);
            this.biletSatBtn.Name = "biletSatBtn";
            this.biletSatBtn.Size = new System.Drawing.Size(207, 33);
            this.biletSatBtn.TabIndex = 7;
            this.biletSatBtn.Text = " Bilet Sat";
            this.biletSatBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.biletSatBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.biletSatBtn.Click += new System.EventHandler(this.biletSatBtn_Click);
            // 
            // filmEkleBtn
            // 
            this.filmEkleBtn.BackColor = System.Drawing.Color.Transparent;
            this.filmEkleBtn.BorderColor = System.Drawing.Color.White;
            this.filmEkleBtn.BorderRadius = 5;
            this.filmEkleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.filmEkleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.filmEkleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.filmEkleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.filmEkleBtn.FillColor = System.Drawing.Color.Transparent;
            this.filmEkleBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmEkleBtn.ForeColor = System.Drawing.Color.LightGray;
            this.filmEkleBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.filmEkleBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.filmEkleBtn.HoverState.Image = global::MovieTime.Properties.Resources.selectedAddMovie;
            this.filmEkleBtn.Image = global::MovieTime.Properties.Resources.unselectedAddMovie;
            this.filmEkleBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.filmEkleBtn.ImageOffset = new System.Drawing.Point(16, 0);
            this.filmEkleBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.filmEkleBtn.Location = new System.Drawing.Point(6, 188);
            this.filmEkleBtn.Name = "filmEkleBtn";
            this.filmEkleBtn.Size = new System.Drawing.Size(207, 33);
            this.filmEkleBtn.TabIndex = 6;
            this.filmEkleBtn.Text = " Film - Salon Ekle";
            this.filmEkleBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.filmEkleBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.filmEkleBtn.Click += new System.EventHandler(this.filmEkleBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(47, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "_______________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(5, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU";
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BorderColor = System.Drawing.Color.White;
            this.HomeBtn.BorderRadius = 5;
            this.HomeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeBtn.FillColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.HomeBtn.ForeColor = System.Drawing.Color.LightGray;
            this.HomeBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.HomeBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.ImageOffset = new System.Drawing.Point(16, 0);
            this.HomeBtn.ImageSize = new System.Drawing.Size(22, 22);
            this.HomeBtn.Location = new System.Drawing.Point(6, 135);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(207, 33);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = " Ana Sayfa";
            this.HomeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.Transparent;
            this.sideBar.BorderRadius = 3;
            this.sideBar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sideBar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sideBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sideBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sideBar.FillColor = System.Drawing.Color.White;
            this.sideBar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sideBar.ForeColor = System.Drawing.Color.White;
            this.sideBar.Location = new System.Drawing.Point(0, 135);
            this.sideBar.Name = "sideBar";
            this.sideBar.PressedColor = System.Drawing.Color.Transparent;
            this.sideBar.PressedDepth = 0;
            this.sideBar.ShadowDecoration.BorderRadius = 0;
            this.sideBar.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.sideBar.ShadowDecoration.Depth = 0;
            this.sideBar.Size = new System.Drawing.Size(6, 33);
            this.sideBar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1222, 627);
            this.Controls.Add(this.offPanel);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private Guna.UI2.WinForms.Guna2Button biletSatBtn;
        private Guna.UI2.WinForms.Guna2Button filmEkleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private Guna.UI2.WinForms.Guna2Button sideBar;
        private System.Windows.Forms.Panel offPanel;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private Guna.UI2.WinForms.Guna2ImageButton minimizeBtn;
        private Guna.UI2.WinForms.Guna2Button satisListelemeBtn;
        private Guna.UI2.WinForms.Guna2Button seansEkleBtn;
        private Guna.UI2.WinForms.Guna2Button SilGuncelleBtn;
    }
}