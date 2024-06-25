using ContactsWSIO.Models;
using System.Collections.ObjectModel;

namespace ContactsWSIO.Viewmodel
{
    public class MainViewModel
    {

        public int NumberOfContacts { get; private set; }

        public static ObservableCollection<User> Users { get; set; }

        public MainViewModel()
        {
            DisplayUsers();
            CountUsers();
        }

        public static void DisplayUsers()
        {
            Users = Usermanager.GetUsers();
        }

        public void CountUsers()
        {
            int numberOfContacts = Users.Count;
            NumberOfContacts = numberOfContacts;
        }

    }
}