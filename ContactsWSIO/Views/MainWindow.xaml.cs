using ContactsWSIO.Viewmodel;
using System.Windows;
using System.Windows.Controls;
using ContactsWSIO.Models;
using System;
using System.Linq;

namespace ContactsWSIO.Views
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            GetContactsFromFiles.GetAllContactsFromFiles();
            InitializeComponent();
            
        }

        private void btn_addContact_Click(object sender, RoutedEventArgs e)
        {
            AddContact addContact = new AddContact();
            addContact.Owner = this;
            addContact.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            addContact.Show();
        }

        private void testbutton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn_editContact_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn_deleteContact_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn_settings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UserList.Items.Filter = FilterMethod;
        }

        private bool FilterMethod(object obj)
        {
            var user = (User)obj;

            return (user.FirstName.Contains(FilterTextBox.Text)) ||
                (user.LastName.Contains(FilterTextBox.Text)) || 
                (user.Email.Contains(FilterTextBox.Text)) || 
                (user.Phone.Contains(FilterTextBox.Text)) || 
                (user.Mobile.Contains(FilterTextBox.Text));

            //return user.FirstName.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase) || user.LastName.Contains(FilterTextBox.Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}