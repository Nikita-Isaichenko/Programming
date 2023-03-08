using System;
using System.IO;
using System.IO.Enumeration;
using System.Windows;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace View.Model.Services
{
    internal class ContactSerializer
    {

        public string Path { get; set; }
            = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\contacts.json";          

        public ContactSerializer()
        {

        }

        public Contact? Load()
        {
            Contact? contact = new Contact();           

            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    contact = JsonConvert.DeserializeObject<Contact>(sr.ReadToEnd());
                }
            }   

            return contact;
        }

        public void Save(Contact? contact)
        {
            using(StreamWriter wr = new StreamWriter(Path))
            {
                wr.Write(JsonConvert.SerializeObject(contact));
            }
        }
    }
}
