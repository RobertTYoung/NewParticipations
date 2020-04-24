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

namespace _P__WPF___2
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

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNumMax.Text = "";
           lboxList.Items.Clear();
        }

        private void btnExecute_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            string NumMax;
            NumMax = txtNumMax.Text;

            int NumMaxAsNumber = Convert.ToInt32(NumMax);

            for (int i = 0; i <= NumMaxAsNumber; i++)
            {
                if (i % 2 != 0)
                {
                    lboxList.Items.Add(i);
                }
            }
        }

        private void rbtnEven_Checked(object sender, RoutedEventArgs e)
        {
            string NumMax;
            NumMax = txtNumMax.Text;

            int NumMaxAsNumber = Convert.ToInt32(NumMax);
            
            for (int i = 0; i <= NumMaxAsNumber; i++)
            {
                if (i % 2 == 0)
                {
                    lboxList.Items.Add(i);
                }
            }
        }
    }
}
