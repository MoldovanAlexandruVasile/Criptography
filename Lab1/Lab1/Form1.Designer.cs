namespace Lab1
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.encryptedText = new System.Windows.Forms.TextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.defaultEncryptBtn = new System.Windows.Forms.Button();
            this.RandomEncryptBtn = new System.Windows.Forms.Button();
            this.customCryptText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputEncryptBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cryptPathUsedText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(51, 43);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(398, 261);
            this.inputText.TabIndex = 0;
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(166, 345);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(96, 53);
            this.encryptBtn.TabIndex = 1;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypted text:";
            // 
            // encryptedText
            // 
            this.encryptedText.Location = new System.Drawing.Point(51, 437);
            this.encryptedText.Multiline = true;
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.Size = new System.Drawing.Size(398, 294);
            this.encryptedText.TabIndex = 4;
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(288, 345);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(94, 53);
            this.decryptBtn.TabIndex = 5;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // defaultEncryptBtn
            // 
            this.defaultEncryptBtn.Location = new System.Drawing.Point(531, 677);
            this.defaultEncryptBtn.Name = "defaultEncryptBtn";
            this.defaultEncryptBtn.Size = new System.Drawing.Size(117, 53);
            this.defaultEncryptBtn.TabIndex = 6;
            this.defaultEncryptBtn.Text = "Default encrypt";
            this.defaultEncryptBtn.UseVisualStyleBackColor = true;
            this.defaultEncryptBtn.Click += new System.EventHandler(this.defaultEncryptBtn_Click);
            // 
            // RandomEncryptBtn
            // 
            this.RandomEncryptBtn.Location = new System.Drawing.Point(706, 677);
            this.RandomEncryptBtn.Name = "RandomEncryptBtn";
            this.RandomEncryptBtn.Size = new System.Drawing.Size(121, 53);
            this.RandomEncryptBtn.TabIndex = 7;
            this.RandomEncryptBtn.Text = "Random encrypt";
            this.RandomEncryptBtn.UseVisualStyleBackColor = true;
            this.RandomEncryptBtn.Click += new System.EventHandler(this.RandomEncryptBtn_Click);
            // 
            // customCryptText
            // 
            this.customCryptText.Location = new System.Drawing.Point(531, 43);
            this.customCryptText.Multiline = true;
            this.customCryptText.Name = "customCryptText";
            this.customCryptText.Size = new System.Drawing.Size(296, 261);
            this.customCryptText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Input your own ecryption path:";
            // 
            // inputEncryptBtn
            // 
            this.inputEncryptBtn.Location = new System.Drawing.Point(534, 311);
            this.inputEncryptBtn.Name = "inputEncryptBtn";
            this.inputEncryptBtn.Size = new System.Drawing.Size(293, 33);
            this.inputEncryptBtn.TabIndex = 10;
            this.inputEncryptBtn.Text = "Use encrypt path";
            this.inputEncryptBtn.UseVisualStyleBackColor = true;
            this.inputEncryptBtn.Click += new System.EventHandler(this.inputEncryptBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Used crypting path:";
            // 
            // cryptPathUsedText
            // 
            this.cryptPathUsedText.Location = new System.Drawing.Point(534, 437);
            this.cryptPathUsedText.Multiline = true;
            this.cryptPathUsedText.Name = "cryptPathUsedText";
            this.cryptPathUsedText.ReadOnly = true;
            this.cryptPathUsedText.Size = new System.Drawing.Size(293, 166);
            this.cryptPathUsedText.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 777);
            this.Controls.Add(this.cryptPathUsedText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputEncryptBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customCryptText);
            this.Controls.Add(this.RandomEncryptBtn);
            this.Controls.Add(this.defaultEncryptBtn);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptedText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox encryptedText;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button defaultEncryptBtn;
        private System.Windows.Forms.Button RandomEncryptBtn;
        private System.Windows.Forms.TextBox customCryptText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inputEncryptBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cryptPathUsedText;
    }
}

