using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Model.Services
{
    public static class ContactSerializer
    {
        private static string _filePath
        {
            get
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                return Path.Combine(documentsPath, "Contacts", "contacts.json");
            }
        }

        public static void SaveContact(Contact contact)
        {
            if (!File.Exists(_filePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_filePath));
            }

            string json = JsonConvert.SerializeObject(contact);
            File.WriteAllText(_filePath, json);
        }

        public static Contact LoadContact()
        {
            if (!File.Exists(_filePath))
            {
                return null;
            }

            string json = File.ReadAllText(_filePath);
            try
            {
                Contact contact = JsonConvert.DeserializeObject<Contact>(json);
                return contact;
            }
            catch
            {
                return null;
            }
        }
    }
}
