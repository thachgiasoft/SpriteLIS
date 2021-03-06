﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Xml;

//namespace ASTMConfig
//{
//    class UserSettingsWriter
//    {
//        protected XmlDocument _doc = null;
//        protected string _encryptionKey;

//        public UserSettingsWriter(string encryptionKey)
//        {
//            _encryptionKey = encryptionKey;
//            _doc = new XmlDocument();

//            // Initialize settings document
//            _doc.AppendChild(_doc.CreateNode(XmlNodeType.XmlDeclaration, null, null));
//            _doc.AppendChild(_doc.CreateElement("Settings"));
//        }

//        /// <summary>
//        /// Saves the current data to the specified file
//        /// </summary>
//        /// <param name="filename"></param>
//        public void Save(string filename)
//        {
//            _doc.Save(filename);
//        }

//        /// <summary>
//        /// Writes a string value
//        /// </summary>
//        /// <param name="key"></param>
//        /// <param name="value"></param>
//        public void Write(string key, string value)
//        {
//            WriteNodeValue(key, value != null ? value : String.Empty);
//        }

//        /// <summary>
//        /// Writes an integer value
//        /// </summary>
//        /// <param name="key"></param>
//        /// <param name="value"></param>
//        public void Write(string key, int value)
//        {
//            WriteNodeValue(key, value);
//        }

//        /// <summary>
//        /// Writes a floating-point value
//        /// </summary>
//        /// <param name="key"></param>
//        /// <param name="value"></param>
//        public void Write(string key, double value)
//        {
//            WriteNodeValue(key, value);
//        }

//        /// <summary>
//        /// Writes a Boolean value
//        /// </summary>
//        /// <param name="key"></param>
//        /// <param name="value"></param>
//        public void Write(string key, bool value)
//        {
//            WriteNodeValue(key, value);
//        }

//        /// <summary>
//        /// Writes a DateTime value
//        /// </summary>
//        /// <param name="key"></param>
//        /// <param name="value"></param>
//        public void Write(string key, DateTime value)
//        {
//            WriteNodeValue(key, value);
//        }

//        /// <summary>
//        /// Writes an encrypted string value
//        /// </summary>
//        /// <param name="key"></param>
//        /// <param name="value"></param>
//        public void WriteEncrypted(string key, string value)
//        {
//            SimpleEncryption enc = new SimpleEncryption(_encryptionKey);
//            WriteNodeValue(key, enc.Encrypt(value));
//        }

//        /// <summary>
//        /// Internal method to write a node to the XML document
//        /// </summary>
//        /// <param name="key"></param>
//        /// <param name="value"></param>
//        protected void WriteNodeValue(string key, object value)
//        {
//            XmlElement elem = _doc.CreateElement(key);
//            elem.InnerText = value.ToString();
//            _doc.DocumentElement.AppendChild(elem);
//        }
//    }
//}
