using ContactsWSIO.Model;
using System.Windows;

namespace ContactsWSIO.Views
{
    /// <summary>
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            Verification.GetPasswordFromFile();

            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (lbl_pwbx.Password == Verification.Password)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Das Passwort ist falsch. Bitte versuche es erneut.");
            }
        }
    }
}