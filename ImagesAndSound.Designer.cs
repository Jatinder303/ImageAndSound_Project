namespace ImageAndSound_Project
{
    partial class ImagesAndSound
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
            this.PicBox_Images = new System.Windows.Forms.PictureBox();
            this.Btn_Load = new System.Windows.Forms.Button();
            this.Btn_Spin = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Images)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox_Images
            // 
            this.PicBox_Images.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PicBox_Images.Location = new System.Drawing.Point(149, 35);
            this.PicBox_Images.Name = "PicBox_Images";
            this.PicBox_Images.Size = new System.Drawing.Size(500, 250);
            this.PicBox_Images.TabIndex = 0;
            this.PicBox_Images.TabStop = false;
            // 
            // Btn_Load
            // 
            this.Btn_Load.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Load.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Load.Location = new System.Drawing.Point(204, 350);
            this.Btn_Load.Name = "Btn_Load";
            this.Btn_Load.Size = new System.Drawing.Size(162, 61);
            this.Btn_Load.TabIndex = 1;
            this.Btn_Load.Text = "Load";
            this.Btn_Load.UseVisualStyleBackColor = false;
            this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
            this.Btn_Load.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Btn_Load_KeyDown);
            // 
            // Btn_Spin
            // 
            this.Btn_Spin.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Spin.Enabled = false;
            this.Btn_Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Spin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Spin.Location = new System.Drawing.Point(423, 350);
            this.Btn_Spin.Name = "Btn_Spin";
            this.Btn_Spin.Size = new System.Drawing.Size(162, 61);
            this.Btn_Spin.TabIndex = 2;
            this.Btn_Spin.Text = "Spin";
            this.Btn_Spin.UseVisualStyleBackColor = false;
            this.Btn_Spin.Click += new System.EventHandler(this.Btn_Spin_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Maroon;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Exit.Location = new System.Drawing.Point(626, 350);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(162, 61);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ImagesAndSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.Btn_Spin);
            this.Controls.Add(this.Btn_Load);
            this.Controls.Add(this.PicBox_Images);
            this.Name = "ImagesAndSound";
            this.Text = "Images and Sound Form";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Images)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox_Images;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.Button Btn_Spin;
        private System.Windows.Forms.Button btn_Exit;
    }
}

