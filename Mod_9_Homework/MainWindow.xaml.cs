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

namespace Mod_9_Homework
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

        //Collection to store student objects using List<T>
        List<Student> student = new List<Student>();
        
        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            //Assign variables
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string city = txtCity.Text;

            //New student
            Student student = new Student(firstName, lastName, city);
            this.student.Add(student);

            //Clear textboxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();

        }
    }
}
