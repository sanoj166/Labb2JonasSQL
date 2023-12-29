using Labb2JonasSQL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public partial class StockBalanceWindow : Window
    {
        private readonly BookstoreContext _dbContext;

        public StockBalanceWindow()
        {
            InitializeComponent();

            
            _dbContext = new BookstoreContext();

            
            stockBalanceDataGrid.ItemsSource = _dbContext.StockBalances
                .Include(sb => sb.Store)
                .Include(sb => sb.Book)
                .ToList();
        }
    }
}
