using System;
using System.IO;
using Newtonsoft.Json;

namespace View.Model.Services
{
    internal class ContactSerializer
    {

        public string Path { get; set; }
            = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public ContactSerializer()
        {

        }

        public Contact? Load(string fileName)
        {
            Contact? contact;

            using (StreamReader sr = new StreamReader(Path + fileName))
            {
                contact = JsonConvert.DeserializeObject<Contact>(sr.ReadToEnd());
            }

            return contact;
        }

        public void Save(string fileName, Contact contact)
        {
            using(StreamWriter wr = new StreamWriter(Path + fileName))
            {
                wr.Write(JsonConvert.SerializeObject(contact));
            }
        }
    }
}
