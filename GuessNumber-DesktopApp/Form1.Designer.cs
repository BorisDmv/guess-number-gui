
namespace GuessNumber_DesktopApp
{
    partial class GuessNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessNumber));
            this.textBox = new System.Windows.Forms.TextBox();
            this.InfoText = new System.Windows.Forms.Label();
            this.genText = new System.Windows.Forms.Label();
            this.tryBtn = new System.Windows.Forms.Button();
            this.lifeText = new System.Windows.Forms.Label();
            this.randTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            resources.ApplyResources(this.textBox, "textBox");
            this.textBox.Name = "textBox";
            // 
            // InfoText
            // 
            resources.ApplyResources(this.InfoText, "InfoText");
            this.InfoText.Name = "InfoText";
            // 
            // genText
            // 
            resources.ApplyResources(this.genText, "genText");
            this.genText.Name = "genText";
            // 
            // tryBtn
            // 
            resources.ApplyResources(this.tryBtn, "tryBtn");
            this.tryBtn.FlatAppearance.BorderSize = 0;
            this.tryBtn.Name = "tryBtn";
            this.tryBtn.UseVisualStyleBackColor = true;
            this.tryBtn.Click += new System.EventHandler(this.tryBtn_Click);
            // 
            // lifeText
            // 
            resources.ApplyResources(this.lifeText, "lifeText");
            this.lifeText.Name = "lifeText";
            // 
            // randTxt
            // 
            resources.ApplyResources(this.randTxt, "randTxt");
            this.randTxt.Name = "randTxt";
            // 
            // GuessNumber
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.randTxt);
            this.Controls.Add(this.lifeText);
            this.Controls.Add(this.tryBtn);
            this.Controls.Add(this.genText);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GuessNumber";
            this.Load += new System.EventHandler(this.GuessNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Label genText;
        private System.Windows.Forms.Button tryBtn;
        private System.Windows.Forms.Label lifeText;
        private System.Windows.Forms.Label randTxt;
    }
}

