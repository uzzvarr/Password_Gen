namespace PasswordGen {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.passwordLabel = new System.Windows.Forms.Label();
            this.PasswordLenghtLabel = new System.Windows.Forms.Label();
            this.PasswordLenghtSlider = new System.Windows.Forms.TrackBar();
            this.CopyPasswordBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLenghtSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(89, 67);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(378, 59);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "label1";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLenghtLabel
            // 
            this.PasswordLenghtLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLenghtLabel.Location = new System.Drawing.Point(110, 151);
            this.PasswordLenghtLabel.Name = "PasswordLenghtLabel";
            this.PasswordLenghtLabel.Size = new System.Drawing.Size(338, 59);
            this.PasswordLenghtLabel.TabIndex = 1;
            this.PasswordLenghtLabel.Text = "Password Lenght: 8";
            this.PasswordLenghtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLenghtSlider
            // 
            this.PasswordLenghtSlider.Location = new System.Drawing.Point(117, 230);
            this.PasswordLenghtSlider.Name = "PasswordLenghtSlider";
            this.PasswordLenghtSlider.Size = new System.Drawing.Size(331, 45);
            this.PasswordLenghtSlider.TabIndex = 2;
            this.PasswordLenghtSlider.Scroll += new System.EventHandler(this.PasswordLenghtSlider_Scroll);
            // 
            // CopyPasswordBtn
            // 
            this.CopyPasswordBtn.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyPasswordBtn.Location = new System.Drawing.Point(117, 299);
            this.CopyPasswordBtn.Name = "CopyPasswordBtn";
            this.CopyPasswordBtn.Size = new System.Drawing.Size(331, 54);
            this.CopyPasswordBtn.TabIndex = 3;
            this.CopyPasswordBtn.Text = "Copy Password 🧩";
            this.CopyPasswordBtn.UseVisualStyleBackColor = true;
            this.CopyPasswordBtn.Click += new System.EventHandler(this.CopyPasswordBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.CopyPasswordBtn);
            this.Controls.Add(this.PasswordLenghtSlider);
            this.Controls.Add(this.PasswordLenghtLabel);
            this.Controls.Add(this.passwordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLenghtSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label PasswordLenghtLabel;
        private System.Windows.Forms.TrackBar PasswordLenghtSlider;
        private System.Windows.Forms.Button CopyPasswordBtn;
    }
}

