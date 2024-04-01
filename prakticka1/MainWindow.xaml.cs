
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using prakticka1.SteamDataSetTableAdapters;

namespace prakticka1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        accountTableAdapter account = new accountTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            accountDataGrid.ItemsSource = account.GetData();            
        }
        private void LeftClick(object sender, RoutedEventArgs e)
        {
            GamesPage gamesPage = new GamesPage();
            this.Content = gamesPage;
            gamesPage.BackToMainWindow += Back;
            
        }

        private void RightClick(object sender, RoutedEventArgs e)
        {
            FriendsPage friendsPage = new FriendsPage();
            this.Content = friendsPage;
            friendsPage.BackToMainWindow += Back;
        }
        private void Back(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AccountEF accountEF = new AccountEF();
            this.Content = accountEF;
        }
    }
}