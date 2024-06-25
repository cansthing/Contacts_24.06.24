using ContactsWSIO.Models;
using System;
using System.IO;

namespace ContactsWSIO.Model
{
    public class Verification
    {
        public const string PW_DIR_Path = GetContactsFromFiles.DIR_Contacts + @"Properties\";

        public const string PW_File_Path = GetContactsFromFiles.DIR_Contacts + @"Properties\password.txt";

        public static string Password { get; private set; }

        public Verification()
        {
        }

        public static void TryCreatePassword()
        {
            //Ordner Properties Erstellen

            if (!Directory.Exists(PW_DIR_Path))
            {
                Directory.CreateDirectory(PW_DIR_Path);
            }

            //Passwortdatei erstellen
            if (!File.Exists(PW_File_Path))
            {
                using (FileStream fs = File.Create(PW_File_Path)) ;
            }
            else if (File.Exists(PW_File_Path))
            {
                File.WriteAllText(PW_File_Path, Password);
            }
        }

        public static void GetPasswordFromFile()
        {
            try
            {
                string password = File.ReadAllText(PW_File_Path);
                Password = password;
            }
            catch (Exception ex)
            {
            }

            if (!File.Exists(PW_File_Path))
            {
                TryCreatePassword();
            }
        }

        public static void EditPassword(string newPassword)
        {
            Password = newPassword;
            File.WriteAllText(PW_File_Path, newPassword);
        }

        public static void DeletePassword()
        {
            File.Delete(PW_File_Path);
        }
    }
}