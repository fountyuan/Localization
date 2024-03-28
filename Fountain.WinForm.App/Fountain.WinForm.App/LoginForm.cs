using System;
using System.Windows.Forms;

namespace Fountain.WinForm.App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                LocalizationManager.Resource(this.Name);
                LocalizationManager.Switching(this);

                this.BindComboBox();


            }
            catch
            {
            }
        }
        /// <summary>
        /// /
        /// </summary>
        private void BindComboBox()
        {
            this.LanguageCombo.DataSource = LocalizationManager.SupportList;
            this.LanguageCombo.DisplayMember = "Description";
            this.LanguageCombo.ValueMember = "Country";
            this.LanguageCombo.SelectedValue = LocalizationManager.Language.Country;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LanguageCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selectLanguage = Convert.ToString(this.LanguageCombo.SelectedValue);
                if (LocalizationManager.SupportLanguage.ContainsKey(selectLanguage))
                {
                    LocalizationManager.Language = LocalizationManager.SupportLanguage[selectLanguage];
                    LocalizationManager.Resource(this.Name);
                    LocalizationManager.Switching(this);
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextAccount_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.TextPassword.Focus();
                }
            }
            catch
            {

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.LoginButton.Focus();
                }
            }
            catch
            {

            }
        }
    }
}
