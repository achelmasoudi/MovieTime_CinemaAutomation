namespace MovieTime
{
    partial class UcretGuncelle
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.minimizeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.filmGuncelleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tamUcreti = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ogrenciUcreti = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.ogrenciUcreti);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.tamUcreti);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.minimizeBtn);
            this.guna2Panel1.Controls.Add(this.closeBtn);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.filmGuncelleBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(664, 351);
            this.guna2Panel1.TabIndex = 112;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(189, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 59);
            this.label2.TabIndex = 97;
            this.label2.Text = "Ücret Güncelle";
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
            this.filmGuncelleBtn.Location = new System.Drawing.Point(204, 269);
            this.filmGuncelleBtn.Name = "filmGuncelleBtn";
            this.filmGuncelleBtn.PressedColor = System.Drawing.Color.DarkBlue;
            this.filmGuncelleBtn.PressedDepth = 60;
            this.filmGuncelleBtn.Size = new System.Drawing.Size(249, 49);
            this.filmGuncelleBtn.TabIndex = 108;
            this.filmGuncelleBtn.Text = "Ücret Güncelle";
            this.filmGuncelleBtn.Click += new System.EventHandler(this.filmGuncelleBtn_Click);
            // 
            // tamUcreti
            // 
            this.tamUcreti.BackColor = System.Drawing.Color.Transparent;
            this.tamUcreti.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.tamUcreti.BorderRadius = 5;
            this.tamUcreti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tamUcreti.DefaultText = "";
            this.tamUcreti.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tamUcreti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tamUcreti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tamUcreti.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tamUcreti.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(56)))), ((int)(((byte)(216)))));
            this.tamUcreti.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamUcreti.ForeColor = System.Drawing.Color.Black;
            this.tamUcreti.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.tamUcreti.IconLeft = global::MovieTime.Properties.Resources.ucretIcon;
            this.tamUcreti.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.tamUcreti.IconLeftSize = new System.Drawing.Size(18, 18);
            this.tamUcreti.Location = new System.Drawing.Point(360, 157);
            this.tamUcreti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tamUcreti.Name = "tamUcreti";
            this.tamUcreti.PasswordChar = '\0';
            this.tamUcreti.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tamUcreti.PlaceholderText = "";
            this.tamUcreti.SelectedText = "";
            this.tamUcreti.Size = new System.Drawing.Size(231, 34);
            this.tamUcreti.TabIndex = 116;
            this.tamUcreti.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(357, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 115;
            this.label8.Text = "Tam Ücreti";
            // 
            // ogrenciUcreti
            // 
            this.ogrenciUcreti.BackColor = System.Drawing.Color.Transparent;
            this.ogrenciUcreti.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.ogrenciUcreti.BorderRadius = 5;
            this.ogrenciUcreti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ogrenciUcreti.DefaultText = "";
            this.ogrenciUcreti.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ogrenciUcreti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ogrenciUcreti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ogrenciUcreti.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ogrenciUcreti.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(56)))), ((int)(((byte)(216)))));
            this.ogrenciUcreti.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrenciUcreti.ForeColor = System.Drawing.Color.Black;
            this.ogrenciUcreti.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(33)))), ((int)(((byte)(182)))));
            this.ogrenciUcreti.IconLeft = global::MovieTime.Properties.Resources.ucretIcon;
            this.ogrenciUcreti.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.ogrenciUcreti.IconLeftSize = new System.Drawing.Size(18, 18);
            this.ogrenciUcreti.Location = new System.Drawing.Point(66, 157);
            this.ogrenciUcreti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ogrenciUcreti.Name = "ogrenciUcreti";
            this.ogrenciUcreti.PasswordChar = '\0';
            this.ogrenciUcreti.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ogrenciUcreti.PlaceholderText = "";
            this.ogrenciUcreti.SelectedText = "";
            this.ogrenciUcreti.Size = new System.Drawing.Size(231, 34);
            this.ogrenciUcreti.TabIndex = 118;
            this.ogrenciUcreti.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(63, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 117;
            this.label1.Text = "Öğrenci Ücreti";
            // 
            // UcretGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(664, 351);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UcretGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UcretGuncelle";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton minimizeBtn;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button filmGuncelleBtn;
        private Guna.UI2.WinForms.Guna2TextBox tamUcreti;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox ogrenciUcreti;
        private System.Windows.Forms.Label label1;
    }
}