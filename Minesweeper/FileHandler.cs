using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace Minesweeper
{
    class FileHandler
    {
        public static void Save<T>(T serializableObject, string fileName)
        {
            if (!Directory.Exists("score/"))
            {
                Directory.CreateDirectory("score/");
            }
            string filePath = "score/" + fileName + ".xml";
            var serializer = new DataContractSerializer(typeof(T));
            var settings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t",
            };
            var writer = XmlWriter.Create(filePath, settings);
            serializer.WriteObject(writer, serializableObject);
            writer.Close();
        }
        public static T Load<T>(string filepath)
        {
            if (!File.Exists(filepath))
                return default(T);
            var fileStream = new FileStream(filepath, FileMode.Open);
            
            var reader = XmlDictionaryReader.CreateTextReader(fileStream, new XmlDictionaryReaderQuotas());
            var serializer = new DataContractSerializer(typeof(T));
            T serializableObject = (T)serializer.ReadObject(reader, true);
            reader.Close();
            fileStream.Close();
            return serializableObject;
        }
    }
}
