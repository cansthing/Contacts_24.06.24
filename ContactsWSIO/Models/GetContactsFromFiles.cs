using System.Collections.ObjectModel;
using System.IO;

namespace ContactsWSIO.Models
{
    public class GetContactsFromFiles
    {
        public const string DIR_Contacts = @"C:\Users\Löwen\Desktop\Contacts\";

        private static string[] contacts = Directory.GetDirectories(DIR_Contacts);

        public static void GetAllContactsFromFiles()
        {
            string firstname = "";
            string lastname = "";
            string email = "";
            string phone = "";
            string mobile = "";
            string birthday = "";

            foreach (string contact in contacts)
            {
                string[] files = Directory.GetFiles(contact);

                foreach (string file in files)
                {
                    string pathToFile = Path.GetFileNameWithoutExtension(file);

                    string fullpath = DIR_Contacts + file + pathToFile;

                    string content = File.ReadAllText(file);

                    if (file.Contains("Firstname"))
                    {
                        firstname = content;
                    }
                    else if (file.Contains("Lastname"))
                    {
                        lastname = content;
                    }
                    else if (file.Contains("Email"))
                    {
                        email = content;
                    }
                    else if (file.Contains("Phone"))
                    {
                        phone = content;
                    }
                    else if (file.Contains("Mobil"))
                    {
                        mobile = content;
                    }
                    else if (file.Contains("Birthday"))
                    {
                        birthday = content;
                    }
                }

                Usermanager.AddUserMethod(new User()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Email = email,
                    Phone = phone,
                    Mobile = mobile,
                    Birthday = birthday,
                });
            }
        }

        public GetContactsFromFiles()
        {
        }
    }
}