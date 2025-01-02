namespace PasswordGenerator
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
            GenButton = new Button();
            PasswordText = new Label();
            SuspendLayout();
            // 
            // GenButton
            // 
            GenButton.Location = new Point(334, 189);
            GenButton.Name = "GenButton";
            GenButton.Size = new Size(94, 29);
            GenButton.TabIndex = 0;
            GenButton.Text = "Generate";
            GenButton.UseVisualStyleBackColor = true;
            GenButton.Click += GenButton_Click;
            // 
            // PasswordText
            // 
            PasswordText.AutoSize = true;
            PasswordText.Location = new Point(356, 143);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(46, 20);
            PasswordText.TabIndex = 1;
            PasswordText.Text = "Temp";
            PasswordText.Click += PasswordText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PasswordText);
            Controls.Add(GenButton);
            Name = "Form1";
            Text = "Password Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenButton;
        private Label PasswordText;
    }
}
