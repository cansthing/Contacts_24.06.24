using System.Collections.ObjectModel;
using System.Reflection;
using System.Security.Policy;

namespace ContactsWSIO.Models
{
    public class Usermanager
    {
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>();

        public static ObservableCollection<User> GetUsers()
        {
            return _DatabaseUsers;
        }

        public static void AddUserMethod(User user)
        {
            _DatabaseUsers.Add(user);
        }

        public Usermanager()
        {
            
        }
    }
}