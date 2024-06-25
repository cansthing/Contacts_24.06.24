using ContactsWSIO.Models;
using ContactsWSIO.Viewmodel;
using System.Windows;
using System.Windows.Input;

namespace ContactsWSIO.Views
{
    /// <summary>
    /// Interaktionslogik für AddContact.xaml
    /// </summary>
    public partial class AddContact : Window
    {
        public const string FILE_EXT = CreateContactFiles.FILE_EXT;
        public const string firstPartOfUrl = GetContactsFromFiles.DIR_Contacts;

        public AddContact()
        {
            InitializeComponent();

            //tb_firstname.Text = "Vorname";
            //tb_lastname.Text = "Nachname";
            //tb_email.Text = "Email";
            //tb_phone.Text = "Phone";
            //tb_mobile.Text = "Mobil";
        }

        private void Btn_esc_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Btn_saveContact_Click(object sender, RoutedEventArgs e)
        {
            string firstname = tb_firstname.Text;
            string lastname = tb_lastname.Text;
            string email = tb_email.Text;
            string phone = tb_phone.Text;
            string mobile = tb_mobile.Text;
            string birthday = tb_birthday.Text;

            CreateUser(firstPartOfUrl, firstname, lastname, email, phone, mobile, birthday);
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            tb_firstname.Text = "";
            tb_lastname.Text = "";
            tb_email.Text = "";
            tb_phone.Text = "";
            tb_mobile.Text = "";
            //tb_birthday.Text = "";
        }

        public void CreateUser(string dirPath, string firstname, string lastname, string email, string phone, string mobile, string birthday)
        {
            string nameOfNewContact = firstname + " " + lastname;

            string fullURL = dirPath + nameOfNewContact;

            CreateContactFiles.TryCreateDirectory(dirPath);
            CreateContactFiles.TryCreateDirectory(dirPath + @"Properties");
            CreateContactFiles.TryCreateDirectory(fullURL);

            CreateContactFiles.CreateFiles(fullURL, firstname, lastname, email, phone, mobile, birthday);
            MainViewModel.DisplayUsers();
        }

        private void btn_setbirthday_Click(object sender, RoutedEventArgs e)
        {
            //cal_seld.Visibility = Visibility.Visible;
        }

        private void cal_seld_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
        }
    }
}