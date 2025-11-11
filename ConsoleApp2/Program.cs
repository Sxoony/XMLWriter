
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml;
namespace ConsoleApp2
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            string filepath = "Students.xml";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            
             XmlDocument doc = new XmlDocument();
            using (XmlWriter writer = XmlWriter.Create(filepath, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("School");
               

                
                for (int i = 0; i < 5; i++)
                {
                    writer.WriteStartElement("Student");
                    writer.WriteAttributeString("StudentID",Convert.ToString(i));
                    Console.WriteLine("Enter name:");
                    writer.WriteElementString("Name", Console.ReadLine());
                    Console.WriteLine("Enter age:");
                    writer.WriteElementString("Age", Console.ReadLine());
                    Console.WriteLine("Enter Grade:");
                    writer.WriteElementString("Grade", Console.ReadLine());
                    Console.WriteLine("Enter Gender:");
                    writer.WriteElementString("Gender", Console.ReadLine());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
               
            }
            Console.WriteLine("XML File successfully created.");
            Process.Start("notepad.exe", filepath);
        }

        
    }
}
