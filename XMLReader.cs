using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace CSharpBeginnerTest
{
    public class XMLReader
    {
        public string get_questions_from_xml()
        {
            try
            {
                XmlDocument questionsXmlDocument = new XmlDocument();
                questionsXmlDocument.LoadXml("Questions.xml");
                return questionsXmlDocument.InnerXml;
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}
