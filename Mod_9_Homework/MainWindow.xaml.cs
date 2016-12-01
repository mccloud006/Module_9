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

        //Base index
        int index = 0;

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

        //View Student
        private void ViewStudent(Student student)
        {
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtCity.Text = student.City;
        }

        //Next button
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            this.index++;
            ViewStudent(this.student[this.index]);
            UpdateButtons();
        }

        //Previous button
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            this.index--;
            ViewStudent(this.student[this.index]);
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            btnPrevious.IsEnabled = !(this.index <= 0);
            btnNext.IsEnabled = !(this.index == (this.student.Count -1));
        }
    }
}
