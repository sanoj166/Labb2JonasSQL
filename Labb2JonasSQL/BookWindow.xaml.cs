using Labb2JonasSQL.Data;
using Microsoft.EntityFrameworkCore;
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
    public partial class BookWindow : Window
    {
        private readonly BookstoreContext _dbContext;

        public BookWindow()
        {
            InitializeComponent();

            _dbContext = new BookstoreContext();

            bookDataGrid.ItemsSource = _dbContext.Books.ToList();
        }
    }
}