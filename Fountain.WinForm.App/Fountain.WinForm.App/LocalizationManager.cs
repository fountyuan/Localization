using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Fountain.WinForm.App
{
    public class LocalizationManager
    {
        /// <summary>
        /// 当前语言
        /// </summary>
        public static ResourceInfo Language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static Dictionary<string, Dictionary<string, string>> CacheResource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static Dictionary<string, ResourceInfo> SupportLanguage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public static List<ResourceInfo> SupportList { get; set; }

        /// <summary>
        /// 获取支持语言
        /// </summary>
        /// <returns></returns>
        public static void Support()
        {
            Dictionary<string, ResourceInfo> languages = new Dictionary<string, ResourceInfo>();
            try
            {
                string xmlPath = string.Format("{0}{1}{2}", AppDomain.CurrentDomain.BaseDirectory, "Localization", Path.DirectorySeparatorChar);

                string[] files = Directory.GetFiles(xmlPath);
                for (int i = 0; i < files.Length; i++)
                {
                    XmlReader xmlReader = new XmlTextReader(files[i]);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(xmlReader);

                    XmlNode rootNode = xmlDocument.DocumentElement;

                    ResourceInfo resourceInfo = new ResourceInfo();
                    resourceInfo.Path = files[i];
                    // 检查节点特性
                    if (rootNode.Attributes.Count > 0)
                    {
                        for (int j = 0; j < rootNode.Attributes.Count; j++)
                        {
                            switch (rootNode.Attributes[j].Name)
                            {
                                case "Name": //用于显示
                                    resourceInfo.Description = rootNode.Attributes["Name"].Value;
                                    break;
                                case "Code": // 
                                    resourceInfo.Country = rootNode.Attributes["Code"].Value;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    if (SupportList==null)
                    {
                        SupportList = new List<ResourceInfo>();                        
                    }
                    SupportList.Add(resourceInfo);
                    // 语言编码不能为空
                    if (!string.IsNullOrEmpty(resourceInfo.Country))
                    {
                        if (!languages.ContainsKey(resourceInfo.Country))
                        {
                            // 语言编码不能重复
                            languages.Add(resourceInfo.Country, resourceInfo);
                        }
                    }
                }
            }
            catch
            {

            }
            SupportLanguage = languages;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static void Resource(string xmlNodename)
        {
            Dictionary<string, string> resources = new Dictionary<string, string>();
            CacheResource = new Dictionary<string, Dictionary<string, string>>();
            try
            {
                if (File.Exists(Language.Path))
                {
                    XmlReader xmlReader = new XmlTextReader(Language.Path);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(xmlReader);
                    XmlNode rootNode = xmlDocument.DocumentElement;

                    XmlNodeList xmlNodeList = rootNode.SelectNodes(xmlNodename);
                    
                    foreach (XmlNode itemNode in xmlNodeList)
                    {
                        if (itemNode.Attributes.Count > 0)
                        {
                            for (int x = 0; x < itemNode.Attributes.Count; x++)
                            {
                                if ("Text".Equals(itemNode.Attributes[x].Name))
                                {
                                    if (!resources.ContainsKey(itemNode.Name))
                                    {
                                        resources.Add(itemNode.Name, itemNode.Attributes["Text"].Value);
                                    }
                                    else
                                    {
                                        resources[itemNode.Name]=itemNode.Attributes["Text"].Value;
                                    }
                                }
                            }
                        }
                        XmlNodeList nodelist = itemNode.ChildNodes;
                        for (int i = 0; i < nodelist.Count; i++)
                        {
                            XmlNodeList nodelists = nodelist[i].ChildNodes;
                            for (int j = 0; j < nodelists.Count; j++)
                            {
                                if (!resources.ContainsKey(nodelists[j].Name))
                                {
                                    resources.Add(nodelists[j].Name, nodelists[j].Attributes["Text"].Value);
                                }
                                else
                                {
                                    resources[nodelists[j].Name] = nodelists[j].Attributes["Text"].Value;
                                }
                            }
                        }
                    }
                    if (CacheResource == null)
                    {
                        CacheResource = new Dictionary<string, Dictionary<string, string>>();
                    }
                    if (!CacheResource.ContainsKey(xmlNodename))
                    {
                        CacheResource.Add(xmlNodename, resources);
                    }
                    else
                    {
                        CacheResource[xmlNodename]= resources;
                    }
                }
            }
            catch
            {
            }
        }
        /// <summary>
        /// 切换
        /// </summary>
        /// <param name="control"></param>
        public static void Switching(Control control)
        {
            try
            {
                // 通知变更
                NotifyChanged(control,control.Name);
                // 重绘
                control.Invalidate();
            }
            catch 
            {
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <param name="variable"></param>
        /// <returns></returns>
        internal static string Description(string type,string key, string defaultValue)
        {
            string showText = defaultValue;
            try
            {
                if (CacheResource.ContainsKey(type))
                {
                    Dictionary<string, string> current = CacheResource[type];
                    if (current.ContainsKey(key))
                    {
                        showText = current[key];
                    }
                }
            }
            catch (Exception)
            {
            }
            return showText;
        }
        /// <summary>
        /// 更换标题
        /// </summary>
        /// <param name="notifyControl"></param>
        internal static void NotifyChanged(Control notifyControl,string formName)
        {
            try
            {
                if (notifyControl is Form)
                {
                    notifyControl.Text = Description(formName,notifyControl.Name,notifyControl.Text);
                }
                // 遍历控件上的所有控件  
                foreach (Control itemControl in notifyControl.Controls)
                {
                    // 控件容器
                    if (itemControl.Controls.Count > 0)
                    {
                        if (itemControl is System.Windows.Forms.GroupBox)
                        {
                            itemControl.Text = Description(formName, itemControl.Name, itemControl.Text);
                        }
                        NotifyChanged(itemControl, formName);
                    }
                    // 按钮
                    if (itemControl is Button)
                    {
                        Button button = (Button)itemControl;
                        if (!string.IsNullOrEmpty(button.Text))
                        {
                            button.Text = Description(formName, button.Name, button.Text);
                            button.Invalidate();
                        }
                    }
                    // 标签
                    if (itemControl is System.Windows.Forms.Label)
                    {
                        System.Windows.Forms.Label label = (System.Windows.Forms.Label)itemControl;
                        if (!string.IsNullOrEmpty(label.Text))
                        {
                            label.Text =string.Format("{0}:",Description(formName, label.Name, label.Text));
                            label.Invalidate();
                        }
                    }

                    // 标签
                    if (itemControl is LinkLabel)
                    {
                        LinkLabel linkLabel = (LinkLabel)itemControl;
                        if (!string.IsNullOrEmpty(linkLabel.Text))
                        {
                            linkLabel.Text = Description(formName, linkLabel.Name, linkLabel.Text);
                            linkLabel.Invalidate();
                        }
                    }

                    if (itemControl is System.Windows.Forms.CheckBox)
                    {
                        System.Windows.Forms.CheckBox checkBox = (System.Windows.Forms.CheckBox)itemControl;
                        if (!string.IsNullOrEmpty(checkBox.Text))
                        {
                            checkBox.Text = Description(formName, checkBox.Name, checkBox.Text);
                            checkBox.Invalidate();
                        }
                    }
                    if (itemControl is System.Windows.Forms.RadioButton)
                    {
                        System.Windows.Forms.RadioButton radioButton = (System.Windows.Forms.RadioButton)itemControl;
                        if (!string.IsNullOrEmpty(radioButton.Text))
                        {
                            radioButton.Text = Description(formName, radioButton.Name, radioButton.Text);
                            radioButton.Invalidate();
                        }
                    }

                    if (itemControl is DataGridView)
                    {
                        DataGridView dataGridView = (DataGridView)itemControl;
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(dataGridView.Columns[i].HeaderText))
                            {
                                dataGridView.Columns[i].HeaderText = Description(formName, dataGridView.Columns[i].Name, dataGridView.Columns[i].HeaderText);
                            }
                        }
                    }
                    if (itemControl is TabControl)
                    {
                        TabControl tabControl = (TabControl)itemControl;
                        foreach (TabPage tabPage in tabControl.TabPages)
                        {
                            tabPage.Text = Description(formName, tabPage.Name, tabPage.Text);
                            NotifyChanged(itemControl, formName);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
