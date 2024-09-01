namespace librarymanagement.View
{
    partial class SignupView
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
            this.signupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signupButton
            // 
            this.signupButton.Location = new System.Drawing.Point(284, 243);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(191, 52);
            this.signupButton.TabIndex = 0;
            this.signupButton.Text = "Signup";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // SignupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signupButton);
            this.Name = "SignupView";
            this.Text = "SignupView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signupButton;
    }
}