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

namespace prakticka1
{
    /// <summary>
    /// Логика взаимодействия для FriendsEF.xaml
    /// </summary>
    public partial class FriendsEF : Page
    {
        public EventHandler<EventArgs> BackToAccountEF;
        private SteamEntities friends = new SteamEntities();
        public FriendsEF()
        {
            InitializeComponent();
            FriendsEFDataGrid.ItemsSource = friends.friends.ToList();
            
        }
    }
}
