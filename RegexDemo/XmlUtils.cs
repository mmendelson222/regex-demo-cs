using System.Linq;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Synteractive.Utils
{
    /// <summary>
    /// Container for static xml utilities.
    /// </summary>
    public static class XmlUtils
    {
        #region serialization

        public static void SerializeObject(Object o, string xmlPath)
        {
            SerializeObject(o, xmlPath, null);
        }

        /// <summary>
        /// Serialize an object to a file.
        /// If serializer not specified, use a generic one.
        /// </summary>
        public static void SerializeObject(Object o, string xmlPath, XmlSerializer serializer)
        {
            serializer = Serializer(o.GetType(), serializer);

            //Create the target directory if it does not exist.
            if (!Directory.Exists(Path.GetDirectoryName(xmlPath)))
            {
                if (Path.GetDirectoryName(xmlPath).Trim().Length > 0)
                    Directory.CreateDirectory(Path.GetDirectoryName(xmlPath));
            }

            using (Stream stream = new FileStream(xmlPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                serializer.Serialize(stream, o);
                stream.Close();
            }
        }

        public static string SerializeObject(Object o, bool useLineBreaks)
        {
            return SerializeObject(o, null, useLineBreaks);
        }

        /// <summary>
        /// Serialize an object to a string, which is returned.
        /// </summary>
        public static string SerializeObject(Object o, XmlSerializer serializer, bool useLineBreaks)
        {
            serializer = Serializer(o.GetType(), serializer);
            using (StringWriter sw = new StringWriter())
            {
                XmlTextWriter writer = new XmlTextWriter(sw);
                if (useLineBreaks) writer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, o);
                sw.Close();
                return sw.ToString();
            }
        }

        public static object DeserializeFromFile(System.Type t, string xmlPath)
        {
            return DeserializeFromFile(t, xmlPath, null);
        }

        public static object DeserializeFromFile(System.Type t, string xmlPath, XmlSerializer serializer)
        {
            serializer = Serializer(t, serializer);
            using (Stream stream = new FileStream(xmlPath, FileMode.Open, FileAccess.Read))
            {
                Object o = null;
                try
                {
                    o = serializer.Deserialize(stream);
                }
                catch (Exception e)
                {
                    //CurrentLog.Instance.Log(eLogLevel.Exception, "This might occur when deserializing a bad config file");
                    throw e;
                }
                finally
                {
                    stream.Close();
                }
                return o;
            }
        }

        public static object DeserializeFromString(System.Type t, string xmlString)
        {
            return DeserializeFromString(t, xmlString, null);
        }

        public static object DeserializeFromString(System.Type t, string xmlString, XmlSerializer serializer)
        {
            serializer = Serializer(t, serializer);
            object o = null;
            //try
            //{
            o = serializer.Deserialize(new StringReader(xmlString));
            //}
            //catch (System.InvalidOperationException ex)
            //{
            //    CurrentLog.Instance.Log("An error occurred: " + ex.Message);
            //}
            return o;
        }

        /// <summary>
        /// Determine the default serializer for this object, as follows:
        /// 1. Serializer was named explicitly.
        /// 2. Type has a serializer associated with it. (removed!)
        /// 3. Standard serializer.
        /// </summary>
        public static XmlSerializer Serializer(Type t, XmlSerializer preferredSerializer)
        {
            //first choice: serializer named explicitly.
            if (null != preferredSerializer) return preferredSerializer;

            //second choice: Standard serializer for this type.
            return new XmlSerializer(t);
        }
        #endregion


    }

    public class XmlConfig
    {
        public ConfigSet[] Configs { get; set; }

        public ConfigSet this[string name]
        {
            get
            {
                return this.Configs.Where(c => c.Name == name).FirstOrDefault();
            }
        }
    }

    public class ConfigSet
    {
        public string Name { get; set; }
        public string Pattern { get; set; }
        public string Text { get; set; }
    }


}
