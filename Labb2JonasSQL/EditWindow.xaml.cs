using Labb2JonasSQL.Data;
using Labb2JonasSQL.Models;
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
    public partial class EditWindow : Window
    {
        private readonly BookstoreContext _dbContext;

        public EditWindow()
        {
            InitializeComponent();

            _dbContext = new BookstoreContext();

            
            isbnComboBox.ItemsSource = _dbContext.Books.ToList();

            
            storeIdComboBox.ItemsSource = _dbContext.Stores.ToList();
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            
            string isbn = (isbnComboBox.SelectedItem as Book)?.ISBN13;
            int storeId = (storeIdComboBox.SelectedItem as Store)?.StoreId ?? 0; 
            int quantity = int.Parse(quantityTextBox.Text);

            
            var stockBalance = _dbContext.StockBalances
                .SingleOrDefault(sb => sb.ISBN13 == isbn && sb.StoreId == storeId);

            
            if (stockBalance == null)
            {
                stockBalance = new StockBalance
                {
                    ISBN13 = isbn,
                    StoreId = storeId,
                    Quantity = quantity
                };
                _dbContext.StockBalances.Add(stockBalance);
            }
            else
            {
                
                stockBalance.Quantity += quantity;
            }

            
            _dbContext.SaveChanges();

            MessageBox.Show($"Successfully added {quantity} copies of {isbn} to the stock.", "Success");


            //Close();
        }



        private void RemoveBook_Click(object sender, RoutedEventArgs e)
        {
            
            string isbn = (isbnComboBox.SelectedItem as Book)?.ISBN13;
            int storeId = (storeIdComboBox.SelectedItem as Store)?.StoreId ?? 0; 
            int quantity = int.Parse(quantityTextBox.Text);

            
            var stockBalance = _dbContext.StockBalances
                .SingleOrDefault(sb => sb.ISBN13 == isbn && sb.StoreId == storeId);

            
            if (stockBalance != null)
            {
                stockBalance.Quantity -= quantity;

                
                stockBalance.Quantity = Math.Max(stockBalance.Quantity, 0);

                
                _dbContext.SaveChanges();

                MessageBox.Show($"Successfully removed {quantity} copies of {isbn} from the stock.", "Success");
            }

            
            //Close();
        }
    }
}
