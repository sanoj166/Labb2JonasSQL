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
using System.Windows.Shapes;

namespace Labb2JonasSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ViewStockBalance_Click(object sender, RoutedEventArgs e)
        {
            StockBalanceWindow stockBalanceWindow = new StockBalanceWindow();
            stockBalanceWindow.Owner = this;
            stockBalanceWindow.ShowDialog();
        }

        private void EditWindow_Click(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow();
            editWindow.ShowDialog();
        }

        private void BookWindow_Click(object sender, RoutedEventArgs e)
        {
            BookWindow bookWindow = new BookWindow();
            bookWindow.ShowDialog();
        }

        private void EditBooks_Click(object sender, RoutedEventArgs e)
        {
            EditBookWindow editBookWindow = new EditBookWindow();
            editBookWindow.Owner = this;
            editBookWindow.ShowDialog();
        }


        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
