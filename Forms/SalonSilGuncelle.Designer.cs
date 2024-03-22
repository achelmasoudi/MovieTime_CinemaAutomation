namespace MovieTime.Forms
{
    partial class SalonSilGuncelle
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
            this.label2 = new System.Windows.Forms.Label();
            this.salonComB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salonSilBtn = new Guna.UI2.WinForms.Guna2Button();
            this.filmGuncelleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.salonAdiTxtB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.minimizeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(130, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 59);
            this.label2.TabIndex = 97;
            this.label2.Text = "Salon Sil veya Güncelle";
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
            this.salonComB.Location = new System.Drawing.Point(69, 160);
            this.salonComB.Name = "salonComB";
            this.salonComB.Size = new System.Drawing.Size(236, 34);
            this.salonComB.TabIndex = 99;
            this.salonComB.SelectedIndexChanged += new System.EventHandler(this.salonComB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(66, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 98;
            this.label1.Text = "Salon Adı";
            // 
            // salonSilBtn
            // 
            this.salonSilBtn.BackColor = System.Drawing.Color.Transparent;
            this.salonSilBtn.BorderColor = System.Drawing.Color.White;
            this.salonSilBtn.BorderRadius = 5;
            this.salonSilBtn.BorderThickness = 1;
            this.salonSilBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.salonSilBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.salonSilBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.salonSilBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.salonSilBtn.FillColor = System.Drawing.Color.Red;
            this.salonSilBtn.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold);
            this.salonSilBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.salonSilBtn.HoverState.FillColor = System.Drawing.Color.Red;
            this.salonSilBtn.Location = new System.Drawing.Point(69, 272);
            this.salonSilBtn.Name = "salonSilBtn";
            this.salonSilBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.salonSilBtn.PressedDepth = 60;
            this.salonSilBtn.Size = new System.Drawing.Size(236, 40);
            this.salonSilBtn.TabIndex = 100;
            this.salonSilBtn.Text = "Salon Sil";
            this.salonSilBtn.Click += new System.EventHandler(this.salonSilBtn_Click);
            // 
            // filmGuncelleBtn
            // 
            this.filmGuncelleBtn.BackColor = System.Drawing.Color.Transparent;
            this.filmGuncelleBtn.BorderColor = System.Drawing.Color.White;
            this.filmGuncelleBtn.BorderRadius = 5;
            this.filmGuncelleBtn.BorderThickness = 1;
            this.filmGuncelleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.filmGuncelleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.filmGuncelleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.filmGuncelleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.filmGuncelleBtn.FillColor = System.Drawing.Color.Blue;
            this.filmGuncelleBtn.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmGuncelleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.filmGuncelleBtn.HoverState.FillColor = System.Drawing.Color.Blue;
            this.filmGuncelleBtn.Location = new System.Drawing.Point(360, 272);
            this.filmGuncelleBtn.Name = "filmGuncelleBtn";
            this.filmGuncelleBtn.PressedColor = System.Drawing.Color.DarkBlue;
            this.filmGuncelleBtn.PressedDepth = 60;
            this.filmGuncelleBtn.Size = new System.Drawing.Size(236, 40);
            this.filmGuncelleBtn.TabIndex = 108;
            this.filmGuncelleBtn.Text = "Salon Güncelle";
            this.filmGuncelleBtn.Click += new System.EventHandler(this.filmGuncelleBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(361, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 110;
            this.label3.Text = "Salon Adı";
            // 
            // salonAdiTxtB
            // 
            this.salonAdiTxtB.BackColor = System.Drawing.Color.Transparent;
            this.salonAdiTxtB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.salonAdiTxtB.BorderRadius = 5;
            this.salonAdiTxtB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salonAdiTxtB.DefaultText = "";
            this.salonAdiTxtB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.salonAdiTxtB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.salonAdiTxtB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salonAdiTxtB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salonAdiTxtB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(56)))), ((int)(((byte)(216)))));
            this.salonAdiTxtB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salonAdiTxtB.ForeColor = System.Drawing.Color.Black;
            this.salonAdiTxtB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.salonAdiTxtB.IconLeft = global::MovieTime.Properties.Resources.salonAdiICon;
            this.salonAdiTxtB.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.salonAdiTxtB.IconLeftSize = new System.Drawing.Size(18, 18);
            this.salonAdiTxtB.Location = new System.Drawing.Point(360, 160);
            this.salonAdiTxtB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salonAdiTxtB.Name = "salonAdiTxtB";
            this.salonAdiTxtB.PasswordChar = '\0';
            this.salonAdiTxtB.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.salonAdiTxtB.PlaceholderText = "";
            this.salonAdiTxtB.SelectedText = "";
            this.salonAdiTxtB.Size = new System.Drawing.Size(236, 34);
            this.salonAdiTxtB.TabIndex = 109;
            this.salonAdiTxtB.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.minimizeBtn);
            this.guna2Panel1.Controls.Add(this.closeBtn);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.filmGuncelleBtn);
            this.guna2Panel1.Controls.Add(this.salonAdiTxtB);
            this.guna2Panel1.Controls.Add(this.salonComB);
            this.guna2Panel1.Controls.Add(this.salonSilBtn);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(664, 351);
            this.guna2Panel1.TabIndex = 111;
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
            this.minimizeBtn.Location = new System.Drawing.Point(34, 7);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.PressedState.Image = global::MovieTime.Properties.Resources.selectedMinimize;
            this.minimizeBtn.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.minimizeBtn.Size = new System.Drawing.Size(24, 24);
            this.minimizeBtn.TabIndex = 112;
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
            this.closeBtn.Location = new System.Drawing.Point(7, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.PressedState.Image = global::MovieTime.Properties.Resources.selectedClose;
            this.closeBtn.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.closeBtn.Size = new System.Drawing.Size(24, 24);
            this.closeBtn.TabIndex = 111;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // SalonSilGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(664, 351);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalonSilGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalonSilGuncelle";
            this.Load += new System.EventHandler(this.SalonSilGuncelle_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox salonComB;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button salonSilBtn;
        private Guna.UI2.WinForms.Guna2Button filmGuncelleBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox salonAdiTxtB;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton minimizeBtn;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
    }
}