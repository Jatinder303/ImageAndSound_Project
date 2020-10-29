
namespace ImageAndSound_Project
{
    partial class InstructionForm
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
            this.lbl_Instuctions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Instuctions
            // 
            this.lbl_Instuctions.AutoSize = true;
            this.lbl_Instuctions.Location = new System.Drawing.Point(290, 63);
            this.lbl_Instuctions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Instuctions.Name = "lbl_Instuctions";
            this.lbl_Instuctions.Size = new System.Drawing.Size(232, 26);
            this.lbl_Instuctions.TabIndex = 0;
            this.lbl_Instuctions.Text = "This is a Simple Game";
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(824, 501);
            this.Controls.Add(this.lbl_Instuctions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "InstructionForm";
            this.Text = "InstructionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Instuctions;
    }
}