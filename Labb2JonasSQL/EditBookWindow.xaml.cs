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
    public partial class EditBookWindow : Window
    {
        private readonly BookstoreContext _dbContext;

        public EditBookWindow()
        {
            InitializeComponent();

            _dbContext = new BookstoreContext();

            titleComboBox.ItemsSource = _dbContext.Books.ToList();
        }

        private void TitleComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (titleComboBox.SelectedItem is Book selectedBook)
            {
                
                languageTextBox.Text = selectedBook.Language;
                priceTextBox.Text = selectedBook.Price?.ToString();

                
                languageTextBox.IsEnabled = true;
                priceTextBox.IsEnabled = true;
            }
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            if (titleComboBox.SelectedItem is Book selectedBook)
            {
                
                selectedBook.Language = languageTextBox.Text;

                
                if (decimal.TryParse(priceTextBox.Text, out decimal newPrice))
                {
                    selectedBook.Price = newPrice;
                }

                
                _dbContext.SaveChanges();

                
                MessageBox.Show("Changes saved successfully.");

                
                Close();
            }
        }
    }
}
