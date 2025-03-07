namespace MatriceUprava
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NactiSouboryBtn = new Button();
            SuspendLayout();
            // 
            // NactiSouboryBtn
            // 
            NactiSouboryBtn.Location = new Point(78, 47);
            NactiSouboryBtn.Name = "NactiSouboryBtn";
            NactiSouboryBtn.Size = new Size(112, 23);
            NactiSouboryBtn.TabIndex = 0;
            NactiSouboryBtn.Text = "Načti soubory";
            NactiSouboryBtn.UseVisualStyleBackColor = true;
            NactiSouboryBtn.Click += NactiSouboryBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NactiSouboryBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button NactiSouboryBtn;
    }
}
