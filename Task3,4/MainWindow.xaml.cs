using System.Windows;
using System.Windows.Controls;

namespace Task3_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<User> users = new List<User>
            {
                new User{Id = 1, Login = "user1", Password = "password1"},
                new User{Id = 2, Login = "user2", Password = "password2"},
                new User{Id = 3, Login = "user3", Password = "password3"},
                new User{Id = 4, Login = "user4", Password = "password4"},
                new User{Id = 5, Login = "user5", Password = "password5"},
            };

            ComboBox.ItemsSource = users;
            ListBox.ItemsSource = users;
            ListView.ItemsSource = users;


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = (User)ComboBox.SelectedItem;
            ComboLabel.Content = $"{user.Id} {user.Login} {user.Password}";
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string users = "";
            foreach (User user in ListBox.SelectedItems)
            {
                users += $"{user.Login}\n";
            }
            ListBoxLabel.Content = users;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string users = "";
            foreach (User user in ListView.SelectedItems)
            {
                users += $"{user.Login}\n";
            }
            ListViewLabel.Content = users;
        }
    }
}