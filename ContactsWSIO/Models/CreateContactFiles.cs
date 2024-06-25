using System.IO;
using System.Text;

namespace ContactsWSIO.Models
{
    public class CreateContactFiles
    {
        public const string FILE_EXT = ".txt";

        public CreateContactFiles()
        {
        }

        public static void CreateFiles(string fullURL, string firstname, string lastname, string email, string phone, string mobile, string birthday)
        {
            CreateFile_FirstName(fullURL, firstname);
            CreateFile_LastName(fullURL, lastname);
            CreateFile_Email(fullURL, email);
            CreateFile_Phone(fullURL, phone);
            CreateFile_Mobile(fullURL, mobile);
            CreateFile_Birthday(fullURL, birthday);
        }

        public static void CreateFile_FirstName(string UrlForNewContact, string firstname)
        {
            string createFileDirectory = UrlForNewContact + @"\";

            if (!Directory.Exists(createFileDirectory))
                Directory.CreateDirectory(createFileDirectory);

            using (FileStream fileStream = File.Create(createFileDirectory + "Firstname" + FILE_EXT))
            {
                byte[] contentConvertedToByte = Encoding.ASCII.GetBytes(firstname);
                fileStream.Write(contentConvertedToByte, 0, contentConvertedToByte.Length);
            }
        }

        public static void CreateFile_LastName(string UrlForNewContact, string lastname)
        {
            string createFileDirectory = UrlForNewContact + @"\";

            if (!Directory.Exists(createFileDirectory))
                Directory.CreateDirectory(createFileDirectory);

            using (FileStream fileStream = File.Create(createFileDirectory + "Lastname" + FILE_EXT))
            {
                byte[] contentConvertedToByte = Encoding.ASCII.GetBytes(lastname);
                fileStream.Write(contentConvertedToByte, 0, contentConvertedToByte.Length);
            }
        }

        public static void CreateFile_Email(string UrlForNewContact, string email)
        {
            string createFileDirectory = UrlForNewContact + @"\";

            if (!Directory.Exists(createFileDirectory))
                Directory.CreateDirectory(createFileDirectory);

            using (FileStream fileStream = File.Create(createFileDirectory + "Email" + FILE_EXT))
            {
                byte[] contentConvertedToByte = Encoding.ASCII.GetBytes(email);
                fileStream.Write(contentConvertedToByte, 0, contentConvertedToByte.Length);
            }
        }

        public static void CreateFile_Phone(string UrlForNewContact, string phone)
        {
            string createFileDirectory = UrlForNewContact + @"\";

            if (!Directory.Exists(createFileDirectory))
                Directory.CreateDirectory(createFileDirectory);

            using (FileStream fileStream = File.Create(createFileDirectory + "Phone" + FILE_EXT))
            {
                byte[] contentConvertedToByte = Encoding.ASCII.GetBytes(phone);
                fileStream.Write(contentConvertedToByte, 0, contentConvertedToByte.Length);
            }
        }

        public static void CreateFile_Mobile(string UrlForNewContact, string mobile)
        {
            string createFileDirectory = UrlForNewContact + @"\";

            if (!Directory.Exists(createFileDirectory))
                Directory.CreateDirectory(createFileDirectory);

            using (FileStream fileStream = File.Create(createFileDirectory + "Mobil" + FILE_EXT))
            {
                byte[] contentConvertedToByte = Encoding.ASCII.GetBytes(mobile);
                fileStream.Write(contentConvertedToByte, 0, contentConvertedToByte.Length);
            }
        }

        public static void CreateFile_Birthday(string UrlForNewContact, string birthday)
        {
            string createFileDirectory = UrlForNewContact + @"\";

            if (!Directory.Exists(createFileDirectory))
                Directory.CreateDirectory(createFileDirectory);

            using (FileStream fileStream = File.Create(createFileDirectory + "Birthday" + FILE_EXT))
            {
                byte[] contentConvertedToByte = Encoding.ASCII.GetBytes(birthday);
                fileStream.Write(contentConvertedToByte, 0, contentConvertedToByte.Length);
            }
        }

        public static void TryCreateDirectory(string URL)
        {
            if (!Directory.Exists(URL))
                Directory.CreateDirectory(URL);
        }

        public static void CreateContactPassword(string dirPath, string password)
        {
            string path = dirPath + @"Properties\";

            File.Create(path + "password" + FILE_EXT);
            File.WriteAllText(path, password);
        }
    }
}