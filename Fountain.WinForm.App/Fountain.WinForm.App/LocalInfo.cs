using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Fountain.WinForm.App
{
    public class LocalInfo
    {
        /// <summary>
        /// 加载
        /// </summary>
        public void Loading()
        {
            try
            {
                LocalizationManager.Support();
                string language = ConfigurationManager.AppSettings["Language"];
                if (string.IsNullOrEmpty(language))
                {
                    language = "zh-CH";
                }
                if (LocalizationManager.SupportLanguage.ContainsKey(language))
                {
                    LocalizationManager.Language = LocalizationManager.SupportLanguage[language];
                }
            }
            catch
            {

            }
        }
    }
}
