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
using wind1.Connect;
using wind1.Std;

namespace wind1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Connector connect = new Connector();
        ObservableCollection<Student> students;
        public MainWindow()
        {
            InitializeComponent();



            students = connect.GetStud();
            StudGrid.ItemsSource = students;
            TextBox1.Text = "puk";

          
           
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
       var res = MessageBox.Show("Do you truly want to delete these  poor unfortunate souls and send them into oblivion? " ,"Confirm", MessageBoxButton.YesNo,MessageBoxImage.Question);
         if(res.Equals(MessageBoxResult.Yes))
            {
                IEnumerable<Student> temp = StudGrid.ItemsSource.Cast<Student>();
              
             
                connect.delStudent(StudGrid.SelectedItems.Cast<Student>());
                StudGrid.ItemsSource = temp.Except(StudGrid.SelectedItems.Cast<Student>()).ToList();

            }
        }

        private void StudGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBox1.Text = StudGrid.SelectedItems.Count.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           AddWindow addW = new AddWindow(connect.getStudies(),connect.getSubjects(),null);
           // addW.Show();
           if(addW.ShowDialog() == false)
            {
                Console.WriteLine("mocha");
                if (addW.stud != null)
                {
                    var st = addW.stud;

                    students.Add(st);
                    StudGrid.Items.Refresh();
                    connect.AddStudent(st);
                }
            }
         
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var target = (Student)StudGrid.SelectedItem;
            AddWindow addW = new AddWindow(connect.getStudies(), connect.getSubjects(), target);
            if (addW.ShowDialog() == false)
            {
                var st = addW.stud;
               
                Console.WriteLine("ZHUK");
              int pos=  students.IndexOf(target);
                students.RemoveAt(pos);
                students.Insert(pos, st);
                connect.updateStud(st);
            }
           
        }
    }
}
