namespace np_image_manual_server
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
            this.ListenButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.ImageShowBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ListenButton
            // 
            this.ListenButton.Location = new System.Drawing.Point(870, 40);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(198, 97);
            this.ListenButton.TabIndex = 0;
            this.ListenButton.Text = "Listen";
            this.ListenButton.UseVisualStyleBackColor = true;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(870, 205);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(198, 97);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(870, 367);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(198, 97);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ImageShowBox
            // 
            this.ImageShowBox.Location = new System.Drawing.Point(29, 40);
            this.ImageShowBox.Name = "ImageShowBox";
            this.ImageShowBox.Size = new System.Drawing.Size(812, 424);
            this.ImageShowBox.TabIndex = 3;
            this.ImageShowBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1108, 506);
            this.Controls.Add(this.ImageShowBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ListenButton);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageShowBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.PictureBox ImageShowBox;
    }
}

