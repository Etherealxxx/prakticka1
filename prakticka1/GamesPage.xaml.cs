using prakticka1.SteamDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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

namespace prakticka1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class GamesPage : Page
    {
        public EventHandler<EventArgs> BackToMainWindow;
        gamesTableAdapter games = new gamesTableAdapter();
        public GamesPage()
        {
            InitializeComponent();
            gamesDataGrid.ItemsSource = games.GetData();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow mainWindow = new MainWindow();          
            mainWindow.Show();
            BackToMainWindow?.Invoke(this, EventArgs.Empty);
        }
    }
}