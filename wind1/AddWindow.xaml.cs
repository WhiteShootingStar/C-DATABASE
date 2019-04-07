using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using wind1.Std;

namespace wind1
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    /// 
    public partial class AddWindow : Window
    {
        public Student stud = null;
        public Student target = null;
        public AddWindow(IEnumerable<string> studies, IEnumerable<string> subj, Student student)
        {
            InitializeComponent();

            CBStudies.ItemsSource = studies;
            CBStudies.SelectedItem = studies.First();
            LBSubject.ItemsSource = subj;
            if (student != null)
            {
                target = student;
                LastNameText.Text = target.LastName;
                FirstNameText.Text = target.FirstName;
                IndexText.Text = target.Index;
               
                CBStudies.SelectedItem = target.Studies;
                BUT1.Content = "Update";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("^s[0-9]*$");
          
          
                
               
                if (regex.IsMatch(IndexText.Text))
                {
                    var a = LBSubject.SelectedItems.Cast<string>();
                if (target != null)
                {
                    stud = new Student { LastName = LastNameText.Text, FirstName = FirstNameText.Text, Address = target.Address, Index = IndexText.Text, Subjects = a, Studies = CBStudies.SelectedValue.ToString() };
                }
                else
                {
                    stud = new Student { LastName = LastNameText.Text, FirstName = FirstNameText.Text, Address = null, Index = IndexText.Text, Subjects = a, Studies = CBStudies.SelectedValue.ToString() };
                }
                   

                    Console.WriteLine("puk");

                    Close();

                }

            
           
        }
        public Student GetStudent()
        {
            return stud;
        }




    }
}
