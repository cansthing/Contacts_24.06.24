using ContactsWSIO.Model;
using ContactsWSIO.Viewmodel;
using System.Windows;

namespace ContactsWSIO.Views
{
    /// <summary>
    /// Interaktionslogik für Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();

            CountContacts();
        }

        private void btn_editPassword_Click(object sender, RoutedEventArgs e)
        {
            string newPassword = pwb_editPassword.Password;

            Verification.EditPassword(newPassword);
        }

        public void CountContacts()
        {
            int numberOfContacts = MainViewModel.Users.Count;

            string info_nOC = $"Du hast {numberOfContacts} Kontakte gespeichert!";

            lbl_info_numberOfContacts.Content = info_nOC;
        }
    }
}