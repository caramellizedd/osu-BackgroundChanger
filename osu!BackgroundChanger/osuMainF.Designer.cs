
namespace osu_BackgroundChanger
{
    partial class osuMainF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(osuMainF));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.OsuImage = new System.Windows.Forms.PictureBox();
            this.ImagePreview = new System.Windows.Forms.PictureBox();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OsuImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(70, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(315, 31);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "osu!BackgroundChanger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Originally made by cayden. Modified by Charamellized.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateBlue;
            this.label2.Location = new System.Drawing.Point(131, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Image DOES NOT look stretched in osu!\r\nThis is purely a limitation of winforms an" +
    "d I am looking to fix this.\r\nIf not possible, I would probably move this to a wp" +
    "f app instead.";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(96)))), ((int)(((byte)(227)))));
            this.ResetButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetButton.BackgroundImage")));
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(580, 186);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(214, 53);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // OsuImage
            // 
            this.OsuImage.Image = ((System.Drawing.Image)(resources.GetObject("OsuImage.Image")));
            this.OsuImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("OsuImage.InitialImage")));
            this.OsuImage.Location = new System.Drawing.Point(12, 9);
            this.OsuImage.Name = "OsuImage";
            this.OsuImage.Size = new System.Drawing.Size(52, 52);
            this.OsuImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OsuImage.TabIndex = 8;
            this.OsuImage.TabStop = false;
            // 
            // ImagePreview
            // 
            this.ImagePreview.BackColor = System.Drawing.Color.SlateBlue;
            this.ImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePreview.Location = new System.Drawing.Point(24, 80);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Size = new System.Drawing.Size(536, 331);
            this.ImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePreview.TabIndex = 6;
            this.ImagePreview.TabStop = false;
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(96)))), ((int)(((byte)(227)))));
            this.ImportButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImportButton.BackgroundImage")));
            this.ImportButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImportButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ImportButton.ForeColor = System.Drawing.Color.White;
            this.ImportButton.Location = new System.Drawing.Point(580, 127);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(214, 53);
            this.ImportButton.TabIndex = 5;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(96)))), ((int)(((byte)(227)))));
            this.ConvertButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConvertButton.BackgroundImage")));
            this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ConvertButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConvertButton.ForeColor = System.Drawing.Color.White;
            this.ConvertButton.Location = new System.Drawing.Point(580, 245);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(214, 53);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(96)))), ((int)(((byte)(227)))));
            this.InfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InfoButton.BackgroundImage")));
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.InfoButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InfoButton.ForeColor = System.Drawing.Color.White;
            this.InfoButton.Location = new System.Drawing.Point(580, 304);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(214, 53);
            this.InfoButton.TabIndex = 2;
            this.InfoButton.Text = "Info";
            this.InfoButton.UseVisualStyleBackColor = false;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // osuMainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(806, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OsuImage);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ImagePreview);
            this.Controls.Add(this.ImportButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.InfoButton);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "osuMainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "osu!BackgroundChanger";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.osuMainF_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.OsuImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.PictureBox ImagePreview;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox OsuImage;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

