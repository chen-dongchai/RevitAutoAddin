using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RevitAutoAddin
{
    public class Function
    {
        public string Type;
        public string FilePath;
        public string GUID;
        public string ProgrameName;
        public string ClassName;
        public string ResultGenerate()
        {
            string result = $"<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?>\r\n<RevitAddIns>\r\n        " +
                $"<AddIn Type=\"{Type}\">\r\n                " +
                $"<Assembly>{FilePath}</Assembly>\r\n                " +
                $"<AddInId>{GUID}</AddInId>\r\n                " +
                $"<FullClassName>{ClassName}</FullClassName>\r\n                " +
                $"<Text>{ProgrameName}</Text> \r\n                " +
                $"<VendorId>NAME</VendorId>\r\n                " +
                $"<VendorDescription>Your Company Information</VendorDescription> \r\n        </AddIn>\r\n</RevitAddIns>";
            return result;
        }
        public Function(string type, string filePath , string gUID,string programeName,string className)
        {
            Type = type;
            FilePath = filePath ;
            GUID = gUID ;
            ProgrameName = programeName ;
            ClassName = className ;
        }
    }
}
