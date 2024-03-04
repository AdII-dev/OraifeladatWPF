using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lbx1.Items.Add("Csütörtök");
            lbx1.Items.Add("Péntek");
            lbx1.Items.Add("Szombat");
            lbx1.Items.Add("Vasárnap");
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult eredmeny = MessageBox.Show("Gizsgugya", "Gyuszi", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation);
            if (eredmeny == MessageBoxResult.Yes)
            {
                lblGombEredmeny.Content = "fasza";
            }
            else
            {
                if (eredmeny == MessageBoxResult.No)
                {
                    lblGombEredmeny.Content = "nem fasza";
                }

                
                else
                {
                    lblGombEredmeny.Content = "Mévonodvissza";
                }


            }

        }
    }
}