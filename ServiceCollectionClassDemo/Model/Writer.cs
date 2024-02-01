using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCollectionClassDemo.Model
{
    public class XMLWriter : IXMLWriter
    {
        public void WriterXML()
        {
            Console.WriteLine("<message>Writing in XML Format</message>");
        }
    }

    public class JSONWriter : IJSONWriter
    {
        public void WriterJSON()
        {
            Console.WriteLine("{'message': 'Writing in JSON Format'}");
        }
    }
}
