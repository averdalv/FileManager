using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager1
{
    class XmlFile:CommonFile
    {
        public XmlFile(string path) : base(path) 
        {
            Name = path.Substring(path.LastIndexOf("\\") + 1); 
        }
        public override string GetContent()
        {
            string text = File.ReadAllText(Path, Encoding.GetEncoding(1251));
            return text;
        }
    }
}
