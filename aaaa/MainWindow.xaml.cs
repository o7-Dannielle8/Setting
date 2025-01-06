using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aaaa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbPass.Visibility = Visibility.Collapsed; // Hide TextBox
        }

        private void ReminderButton_Click(object sender, RoutedEventArgs e)
        {
            SettingReminder settingReminder = new SettingReminder();
            settingReminder.Show();
            this.Hide();
        }

        private void SHPassword_Checked(object sender, RoutedEventArgs e)
        {
            tbPass.Text = pwbox.Password; // Copy password to TextBox
            pwbox.Visibility = Visibility.Collapsed; // Hide PasswordBox
            tbPass.Visibility = Visibility.Visible; // Show TextBox
        }

        private void SHPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            pwbox.Password = tbPass.Text; // Copy text back to PasswordBox
            tbPass.Visibility = Visibility.Collapsed; // Hide TextBox
            pwbox.Visibility = Visibility.Visible; // Show PasswordBox
        }
    }
}