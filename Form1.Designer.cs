namespace Bankomat
{
    partial class Bankomat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.adminHasloTextBox = new System.Windows.Forms.TextBox();
            this.banknotyListBox = new System.Windows.Forms.ListBox();
            this.wartoscBanknotuTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wstawBanknotyButton = new System.Windows.Forms.Button();
            this.ileBanknotowTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kwotaTextBox = new System.Windows.Forms.TextBox();
            this.wyplacButton = new System.Windows.Forms.Button();
            this.adminLogoutButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.zalogujButton = new System.Windows.Forms.Button();
            this.wylogujUserButton = new System.Windows.Forms.Button();
            this.wynikRichTextBox = new System.Windows.Forms.RichTextBox();
            this.KopiujButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(123, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "bankomat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(555, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "opcje administratora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "wprowadź hasło:";
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Location = new System.Drawing.Point(532, 163);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(75, 23);
            this.adminLoginButton.TabIndex = 3;
            this.adminLoginButton.Text = "zaloguj";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            this.adminLoginButton.Click += new System.EventHandler(this.adminLoginButton_Click);
            // 
            // adminHasloTextBox
            // 
            this.adminHasloTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adminHasloTextBox.Location = new System.Drawing.Point(568, 118);
            this.adminHasloTextBox.Name = "adminHasloTextBox";
            this.adminHasloTextBox.Size = new System.Drawing.Size(100, 22);
            this.adminHasloTextBox.TabIndex = 4;
            // 
            // banknotyListBox
            // 
            this.banknotyListBox.FormattingEnabled = true;
            this.banknotyListBox.ItemHeight = 16;
            this.banknotyListBox.Location = new System.Drawing.Point(272, 40);
            this.banknotyListBox.Name = "banknotyListBox";
            this.banknotyListBox.Size = new System.Drawing.Size(213, 100);
            this.banknotyListBox.TabIndex = 5;
            // 
            // wartoscBanknotuTextBox
            // 
            this.wartoscBanknotuTextBox.Location = new System.Drawing.Point(497, 247);
            this.wartoscBanknotuTextBox.Name = "wartoscBanknotuTextBox";
            this.wartoscBanknotuTextBox.Size = new System.Drawing.Size(100, 22);
            this.wartoscBanknotuTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "wprowadź wartość i ilość banknotów do dodania:";
            // 
            // wstawBanknotyButton
            // 
            this.wstawBanknotyButton.Location = new System.Drawing.Point(580, 280);
            this.wstawBanknotyButton.Name = "wstawBanknotyButton";
            this.wstawBanknotyButton.Size = new System.Drawing.Size(75, 23);
            this.wstawBanknotyButton.TabIndex = 8;
            this.wstawBanknotyButton.Text = "dodaj";
            this.wstawBanknotyButton.UseVisualStyleBackColor = true;
            this.wstawBanknotyButton.Click += new System.EventHandler(this.wstawBanknotyButton_Click);
            // 
            // ileBanknotowTextBox
            // 
            this.ileBanknotowTextBox.Location = new System.Drawing.Point(658, 247);
            this.ileBanknotowTextBox.Name = "ileBanknotowTextBox";
            this.ileBanknotowTextBox.Size = new System.Drawing.Size(50, 22);
            this.ileBanknotowTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "wprowadź kwotę do wypłaty:";
            // 
            // kwotaTextBox
            // 
            this.kwotaTextBox.Location = new System.Drawing.Point(109, 236);
            this.kwotaTextBox.Name = "kwotaTextBox";
            this.kwotaTextBox.Size = new System.Drawing.Size(100, 22);
            this.kwotaTextBox.TabIndex = 11;
            // 
            // wyplacButton
            // 
            this.wyplacButton.Location = new System.Drawing.Point(123, 280);
            this.wyplacButton.Name = "wyplacButton";
            this.wyplacButton.Size = new System.Drawing.Size(75, 23);
            this.wyplacButton.TabIndex = 12;
            this.wyplacButton.Text = "wypłać";
            this.wyplacButton.UseVisualStyleBackColor = true;
            this.wyplacButton.Click += new System.EventHandler(this.wyplacButton_Click);
            // 
            // adminLogoutButton
            // 
            this.adminLogoutButton.Location = new System.Drawing.Point(633, 163);
            this.adminLogoutButton.Name = "adminLogoutButton";
            this.adminLogoutButton.Size = new System.Drawing.Size(75, 23);
            this.adminLogoutButton.TabIndex = 13;
            this.adminLogoutButton.Text = "wyloguj";
            this.adminLogoutButton.UseVisualStyleBackColor = true;
            this.adminLogoutButton.Click += new System.EventHandler(this.adminLogoutButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "wprowadź hasło do konta:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginTextBox.Location = new System.Drawing.Point(109, 118);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 22);
            this.loginTextBox.TabIndex = 15;
            // 
            // zalogujButton
            // 
            this.zalogujButton.Location = new System.Drawing.Point(71, 163);
            this.zalogujButton.Name = "zalogujButton";
            this.zalogujButton.Size = new System.Drawing.Size(75, 23);
            this.zalogujButton.TabIndex = 16;
            this.zalogujButton.Text = "zaloguj";
            this.zalogujButton.UseVisualStyleBackColor = true;
            this.zalogujButton.Click += new System.EventHandler(this.zalogujButton_Click);
            // 
            // wylogujUserButton
            // 
            this.wylogujUserButton.Location = new System.Drawing.Point(171, 163);
            this.wylogujUserButton.Name = "wylogujUserButton";
            this.wylogujUserButton.Size = new System.Drawing.Size(75, 23);
            this.wylogujUserButton.TabIndex = 17;
            this.wylogujUserButton.Text = "wyloguj";
            this.wylogujUserButton.UseVisualStyleBackColor = true;
            this.wylogujUserButton.Click += new System.EventHandler(this.wylogujUserButton_Click);
            // 
            // wynikRichTextBox
            // 
            this.wynikRichTextBox.Location = new System.Drawing.Point(272, 247);
            this.wynikRichTextBox.Name = "wynikRichTextBox";
            this.wynikRichTextBox.Size = new System.Drawing.Size(193, 139);
            this.wynikRichTextBox.TabIndex = 18;
            this.wynikRichTextBox.Text = "";
            // 
            // KopiujButton
            // 
            this.KopiujButton.Location = new System.Drawing.Point(327, 392);
            this.KopiujButton.Name = "KopiujButton";
            this.KopiujButton.Size = new System.Drawing.Size(75, 23);
            this.KopiujButton.TabIndex = 19;
            this.KopiujButton.Text = "kopiuj";
            this.KopiujButton.UseVisualStyleBackColor = true;
            this.KopiujButton.Click += new System.EventHandler(this.KopiujButton_Click);
            // 
            // Bankomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.KopiujButton);
            this.Controls.Add(this.wynikRichTextBox);
            this.Controls.Add(this.wylogujUserButton);
            this.Controls.Add(this.zalogujButton);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adminLogoutButton);
            this.Controls.Add(this.wyplacButton);
            this.Controls.Add(this.kwotaTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ileBanknotowTextBox);
            this.Controls.Add(this.wstawBanknotyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wartoscBanknotuTextBox);
            this.Controls.Add(this.banknotyListBox);
            this.Controls.Add(this.adminHasloTextBox);
            this.Controls.Add(this.adminLoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bankomat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bankomat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.TextBox adminHasloTextBox;
        private System.Windows.Forms.ListBox banknotyListBox;
        private System.Windows.Forms.TextBox wartoscBanknotuTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button wstawBanknotyButton;
        private System.Windows.Forms.TextBox ileBanknotowTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kwotaTextBox;
        private System.Windows.Forms.Button wyplacButton;
        private System.Windows.Forms.Button adminLogoutButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button zalogujButton;
        private System.Windows.Forms.Button wylogujUserButton;
        private System.Windows.Forms.RichTextBox wynikRichTextBox;
        private System.Windows.Forms.Button KopiujButton;
    }
}

