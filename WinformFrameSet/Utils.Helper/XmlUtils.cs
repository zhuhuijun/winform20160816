using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace Utils.Helper
{
    /// <summary>
    /// 提供对Xml的一些序列化操作
    /// </summary>
    public class XmlUtils
    {
        #region 属性
        /// <summary>
        /// 获取当前程序路径
        /// </summary>
        private string rootPath;
        public string RootPath
        {
            get { return rootPath; }
            set { rootPath = value; }
        }
        #endregion

        #region 构造方法
        public XmlUtils()
        {
        }
        public XmlUtils(string xmlFileFillPath)
        {
            this.rootPath = xmlFileFillPath;
        }
        public XmlUtils(string appNode, string xmlFilePath)
        {
            this.rootPath = AppDomain.CurrentDomain.BaseDirectory;
            this.rootPath = this.rootPath.Substring(0, this.rootPath.IndexOf("bin"));
            this.rootPath += ConfigurationManager.AppSettings[appNode] + "\\" + xmlFilePath;
        }
        #endregion

        #region 公用方法
        /// <summary>
        ///创建XML文档
        /// </summary>
        /// <param name="xmlpath">文件地址</param>
        /// <param name="root">根节点名称</param>
        public bool CreateXmlFile(string rootName)
        {
            try
            {
                ///创建XDocument类的实例
                XDocument doc = new XDocument(
                    ///XML的声明，包括版本，编码，xml文件是否独立
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement(rootName));
                ///保存XML文件到指定地址
                doc.Save(this.rootPath);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="xmlpath">XML文件的路径</param>
        public bool InsertAndUpDataXmlElement(string rootName, string artName, string value)
        {
            try
            {
                if (!File.Exists(this.rootPath))
                {
                    FileStream myFs = new FileStream(this.rootPath, FileMode.Create);
                    myFs.Close();
                    CreateXmlFile(rootName + "A");
                }
                if (!string.IsNullOrEmpty(value))
                {
                    ///导入XML文件
                    XElement xe = XElement.Load(this.rootPath);
                    lock (xe)
                    {
                        ///查询修改的元素
                        IEnumerable<XElement> element = from e in xe.Elements(rootName)
                                                        select e;
                        if (element.Count() > 0)
                        {
                            var frist = element.First();
                            var elements = frist.Elements().Where(E => E.Name == artName);
                            if (elements.Count() > 0)
                            {
                                var two = elements.First();
                                if (two.Value != value)
                                {
                                    two.ReplaceNodes(value);
                                    ///保存到XML文件中
                                    xe.Save(this.rootPath);
                                }
                            }
                            else
                            {
                                frist.Add(new XElement(artName, value));
                                ///保存到XML文件中
                                xe.Save(this.rootPath);
                            }
                        }
                        else
                        {
                            ///创建一个新节点
                            XElement newNode = new XElement(rootName,
                                               new XElement(artName, value)
                                );
                            ///添加节点到XML文件中，并保存
                            xe.Add(newNode);
                            ///保存到XML文件中
                            xe.Save(this.rootPath);
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="xmlpath">XML文件的路径</param>
        public bool InsertAndUpDataXmlElement(string artName, string value)
        {
            try
            {
                if (!File.Exists(this.rootPath))
                {
                    FileStream myFs = new FileStream(this.rootPath, FileMode.Create);
                    myFs.Close();
                    CreateXmlFile(artName + "A");
                }
                if (!string.IsNullOrEmpty(value))
                {
                    ///导入XML文件
                    XElement xe = XElement.Load(this.rootPath);
                    lock (xe)
                    {
                        ///查询修改的元素
                        IEnumerable<XElement> element = from e in xe.Elements(artName)
                                                        select e;
                        if (element.Count() > 0)
                        {
                            var frist = element.First();
                            if (frist.Value != value)
                            {
                                frist.ReplaceNodes(value);
                                ///保存到XML文件中
                                xe.Save(this.rootPath);
                            }
                        }
                        else
                        {
                            ///创建一个新节点
                            XElement newNode = new XElement(
                                               new XElement(artName, value)
                                );
                            ///添加节点到XML文件中，并保存
                            xe.Add(newNode);
                            ///保存到XML文件中
                            xe.Save(this.rootPath);
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 获取节点值
        /// </summary>
        /// <param name="rootName">跟节点名</param>
        /// <param name="childName">子节点名</param>
        /// <returns></returns>
        public string GetElementValue(string rootName, string childName)
        {
            if (!File.Exists(this.rootPath))
            {
                return null;
            }
            ///导入XML文件
            XElement xe = XElement.Load(this.rootPath);
            ///查询修改的元素
            IEnumerable<XElement> element = from e in xe.Elements(rootName)
                                            select e;
            if (element.Count() > 0)
            {
                var frist = element.First();
                var elements = frist.Elements().Where(E => E.Name == childName);
                if (elements.Count() > 0)
                    return elements.First().Value;
            }
            return string.Empty;
        }
        /// <summary>
        /// 获取节点值
        /// </summary>
        /// <param name="rootName">跟节点名</param>
        /// <param name="childName">子节点名</param>
        /// <returns></returns>
        public string GetElementValue(string childName)
        {
            if (!File.Exists(this.rootPath))
            {
                return null;
            }
            ///导入XML文件
            XElement xe = XElement.Load(this.rootPath);
            ///查询修改的元素
            IEnumerable<XElement> element = from e in xe.Elements(childName)
                                            select e;
            if (element.Count() > 0)
            {
                var frist = element.First().Value;
                return frist;
            }
            return string.Empty;
        }

        /// <summary>
        /// 从指定的Xml文件中反序列化成对象的实例
        /// </summary>
        /// <param name="CurrentType">反序列化后的对象类型</param>
        /// <param name="filePath">要反序列化的Xml文件路径</param>
        /// <returns>返回序列化成功后的对象实例</returns>
        public object Deserialize(Type CurrentType)
        {
            object objObject = null;
            System.IO.FileStream fs = null;
            try
            {
                fs = System.IO.File.Open(this.rootPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                System.Xml.Serialization.XmlSerializer objSerializer = new XmlSerializer(CurrentType);
                objObject = objSerializer.Deserialize(fs);
                return objObject;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs = null;
                }
            }
        }
        #endregion
    }
}
