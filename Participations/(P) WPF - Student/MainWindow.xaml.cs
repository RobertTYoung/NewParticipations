using System;
using System.Collections.Generic;
using System.IO;
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

namespace _P__WPF___Student
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

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            string studentID, FName, LName, FavoriteColor;
            studentID = txtStudentID.Text;
            FName = txtFName.Text;
            LName = txtLName.Text;
            FavoriteColor = txtFavColor.Text;

            lbxStudents.Items.Add($"{FName} {LName} has the StuddentID number {studentID} and their favorite color is {FavoriteColor}.");

            txtStudentID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtFavColor.Clear();
        }

        private void btnStudentData_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Documents\studentdataRandom10Rows.CSV";
          
            if (!File.Exists(path))
            {
                lbxStudents.Items.Add(File.ReadAllLines(path));
            }
        }
    }
}
