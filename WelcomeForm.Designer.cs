
namespace ImageAndSound_Project
{
    partial class WelcomeForm
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
            this.Btn_Play = new System.Windows.Forms.Button();
            this.Btn_rules = new System.Windows.Forms.Button();
            this.lbl_Instuctions = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Play
            // 
            this.Btn_Play.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Play.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Play.Location = new System.Drawing.Point(410, 290);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(162, 61);
            this.Btn_Play.TabIndex = 4;
            this.Btn_Play.Text = "Play";
            this.Btn_Play.UseVisualStyleBackColor = false;
            this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // Btn_rules
            // 
            this.Btn_rules.BackColor = System.Drawing.Color.Maroon;
            this.Btn_rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_rules.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_rules.Location = new System.Drawing.Point(191, 290);
            this.Btn_rules.Name = "Btn_rules";
            this.Btn_rules.Size = new System.Drawing.Size(162, 61);
            this.Btn_rules.TabIndex = 3;
            this.Btn_rules.Text = "Rules";
            this.Btn_rules.UseVisualStyleBackColor = false;
            this.Btn_rules.Click += new System.EventHandler(this.Btn_rules_Click);
            // 
            // lbl_Instuctions
            // 
            this.lbl_Instuctions.AutoSize = true;
            this.lbl_Instuctions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instuctions.Location = new System.Drawing.Point(223, 51);
            this.lbl_Instuctions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Instuctions.Name = "lbl_Instuctions";
            this.lbl_Instuctions.Size = new System.Drawing.Size(232, 26);
            this.lbl_Instuctions.TabIndex = 5;
            this.lbl_Instuctions.Text = "This is a Simple Game";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Maroon;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(612, 290);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(162, 61);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_Instuctions);
            this.Controls.Add(this.Btn_Play);
            this.Controls.Add(this.Btn_rules);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Play;
        private System.Windows.Forms.Button Btn_rules;
        private System.Windows.Forms.Label lbl_Instuctions;
        private System.Windows.Forms.Button btn_exit;
    }
}