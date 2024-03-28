namespace Fountain.WinForm.App
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.LanguageCombo = new System.Windows.Forms.ComboBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.TextAccount = new System.Windows.Forms.TextBox();
            this.LabelWorkbench = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.LanguageLabel);
            this.LoginPanel.Controls.Add(this.LanguageCombo);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.TextPassword);
            this.LoginPanel.Controls.Add(this.AccountLabel);
            this.LoginPanel.Controls.Add(this.TextAccount);
            this.LoginPanel.Controls.Add(this.LabelWorkbench);
            this.LoginPanel.Location = new System.Drawing.Point(109, 21);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(375, 232);
            this.LoginPanel.TabIndex = 0;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginButton.Location = new System.Drawing.Point(148, 158);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(192, 36);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LanguageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LanguageLabel.Location = new System.Drawing.Point(19, 122);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(123, 23);
            this.LanguageLabel.TabIndex = 6;
            this.LanguageLabel.Text = "Language:";
            this.LanguageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LanguageCombo
            // 
            this.LanguageCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageCombo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LanguageCombo.FormattingEnabled = true;
            this.LanguageCombo.Location = new System.Drawing.Point(148, 119);
            this.LanguageCombo.Name = "LanguageCombo";
            this.LanguageCombo.Size = new System.Drawing.Size(192, 28);
            this.LanguageCombo.TabIndex = 5;
            this.LanguageCombo.SelectionChangeCommitted += new System.EventHandler(this.LanguageCombo_SelectionChangeCommitted);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordLabel.Location = new System.Drawing.Point(19, 84);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(123, 23);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password:";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextPassword
            // 
            this.TextPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextPassword.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextPassword.Location = new System.Drawing.Point(148, 82);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(192, 26);
            this.TextPassword.TabIndex = 3;
            this.TextPassword.UseSystemPasswordChar = true;
            this.TextPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextPassword_KeyDown);
            // 
            // AccountLabel
            // 
            this.AccountLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AccountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AccountLabel.Location = new System.Drawing.Point(19, 47);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(123, 23);
            this.AccountLabel.TabIndex = 2;
            this.AccountLabel.Text = "Account:";
            this.AccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextAccount
            // 
            this.TextAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextAccount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextAccount.Location = new System.Drawing.Point(148, 45);
            this.TextAccount.Name = "TextAccount";
            this.TextAccount.Size = new System.Drawing.Size(192, 26);
            this.TextAccount.TabIndex = 1;
            this.TextAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextAccount_KeyDown);
            // 
            // LabelWorkbench
            // 
            this.LabelWorkbench.BackColor = System.Drawing.Color.Transparent;
            this.LabelWorkbench.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelWorkbench.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelWorkbench.Location = new System.Drawing.Point(0, 0);
            this.LabelWorkbench.Name = "LabelWorkbench";
            this.LabelWorkbench.Size = new System.Drawing.Size(375, 32);
            this.LabelWorkbench.TabIndex = 0;
            this.LabelWorkbench.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 279);
            this.Controls.Add(this.LoginPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.TextBox TextAccount;
        private System.Windows.Forms.Label LabelWorkbench;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.ComboBox LanguageCombo;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox TextPassword;
    }
}

