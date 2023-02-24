using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MidCSI124ExamProgramIII
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Product> _products;
        ObservableCollection<Member> _members;
        public MainWindow()
        {
            InitializeComponent();
            lbDisplay1.ItemsSource = _products;
            lbDisplay1.ItemsSource = _members;

            //_products.Add(new Drinks("Hotlatte", 7, 200, Drinks.Size.Tall, 165.99));//

            Preload();
        }
        public void Preload()
        {
           // _products.Add(new Drinks("Butter Crossiant", 7, 200, Drinks.Size.Venti, 4577.87));//
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnAddNewProduct_Click(object sender, RoutedEventArgs e)
        {
            AddNewProductWindow addNewProductWindow = new AddNewProductWindow();    
            addNewProductWindow.Show();
        }

        private void btn4MemberInfo_Click(object sender, RoutedEventArgs e)
        {
            MemberInfofrmation memberInfofrmation = new MemberInfofrmation();
            memberInfofrmation.Show();

        }
    }
}
