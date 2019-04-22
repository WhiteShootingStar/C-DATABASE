using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace wind1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Connector connect = new Connector();
        DBase database = new DBase();
        ObservableCollection<StShow> students;
        List<StShow> result;
        public MainWindow()
        {
            InitializeComponent();


            result = database.Students.ToList().Join(database.Studies.ToList(), std => std.IdStudies, stud => stud.IdStudies, (std, stud) => new StShow { LastName = std.LastName, FirstName = std.FirstName, IndexNumber = std.IndexNumber, Address = std.Address, Name = stud.Name, id = std.IdStudent, IDStudies = std.IdStudies }).ToList();
            //  students = connect.GetStud();
            students = new ObservableCollection<StShow>(result);
            StudGrid.ItemsSource = students;
            TextBox1.Text = "puk";
            foreach (var std in result)
            {
                Console.WriteLine(std);
            }



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var res = MessageBox.Show("Do you truly want to delete these  poor unfortunate souls and send them into oblivion? ", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res.Equals(MessageBoxResult.Yes))
            {



                //  connect.delStudent(StudGrid.SelectedItems.Cast<Student>());
                foreach (StShow student in StudGrid.SelectedItems)
                {
                    Student stdToRemove = database.Students.Where(std => std.IdStudent == student.id).Single();
                    var student_Subjects = database.Student_Subject.Where(std => std.IdStudent == student.id);
                    foreach (var ss in student_Subjects)
                    {
                        database.Student_Subject.Remove(ss);
                    }
                    Console.WriteLine(stdToRemove.IdStudent);

                    database.Students.Remove(stdToRemove);
                    database.SaveChanges();
                    // students.Remove(student);
                }
                //  students=students.re
                StudGrid.ItemsSource = null;
                StudGrid.ItemsSource = database.Students.ToList().Join(database.Studies.ToList(), std => std.IdStudies, stud => stud.IdStudies, (std, stud) => new StShow { LastName = std.LastName, FirstName = std.FirstName, IndexNumber = std.IndexNumber, Address = std.Address, Name = stud.Name, id = std.IdStudent, IDStudies = std.IdStudies }).ToList(); ;
            }
        }

        private void StudGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBox1.Text = StudGrid.SelectedItems.Count.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var studies = database.Studies.ToList();
            var subjects = database.Subjects.ToList();
            AddWindow addW = new AddWindow(studies, subjects, null);

            if (addW.ShowDialog() == false)
            {

                if (addW.stud != null)
                {
                    var st = addW.stud;
                    Student student = new Student { LastName = st.LastName, FirstName = st.FirstName, Address = st.Address, IndexNumber = st.IndexNumber, IdStudies = st.IdStudies, Study = st.Study };

                    database.Students.Add(student);
                    database.SaveChanges();
                    Console.WriteLine(student.IdStudent);
                    foreach (var item in st.Subject)
                    {
                        database.Student_Subject.Add(new Student_Subject { IdStudent = student.IdStudent, IdSubject = item.IdSubject, Student = student, Subject = item, CreatedAt = DateTime.Now });
                        database.SaveChanges();
                    }

                }
            }
            StudGrid.ItemsSource = null;
            StudGrid.ItemsSource = database.Students.ToList().Join(database.Studies.ToList(), std => std.IdStudies, stud => stud.IdStudies, (std, stud) => new StShow { LastName = std.LastName, FirstName = std.FirstName, IndexNumber = std.IndexNumber, Address = std.Address, Name = stud.Name, id = std.IdStudent, IDStudies = std.IdStudies }).ToList(); ;


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var target = (StShow)StudGrid.SelectedItem;
            if (target != null)
            {
                Student tempStudent = new Student { LastName = target.LastName, IndexNumber = target.IndexNumber, IdStudent = target.id, Address = target.Address, FirstName = target.FirstName, IdStudies = target.IDStudies, };
                var studies = database.Studies.ToList();
                var subjects = database.Subjects.ToList();
                AddWindow addW = new AddWindow(studies, subjects, tempStudent);
                if (addW.ShowDialog() == false)
                {
                    if (addW.stud != null)
                    {
                        var st = addW.stud;
                        Student student = new Student { LastName = st.LastName, FirstName = st.FirstName, Address = st.Address, IndexNumber = st.IndexNumber, IdStudies = st.IdStudies, Study = st.Study,IdStudent=target.id };
                       
                        Student stTochange = database.Students.Where(a => a.IdStudent == target.id).First();
                        Console.WriteLine(stTochange);
                        Console.WriteLine(student);
                        database.Entry<Student>(stTochange).CurrentValues.SetValues(student);
                       // stTochange = student;
                        //database.Students.Attach(student);
                        //var entry = database.Entry<Student>(student);
                        //entry.State = System.Data.Entity.EntityState.Modified;

                       // database.SaveChanges();


                        foreach (var item in st.Subject)
                        {
                            var S_S = new Student_Subject { IdStudent = target.id, IdSubject = item.IdSubject, CreatedAt = DateTime.Now };

                            database.Student_Subject.Add(S_S);
                            //var entr = database.Entry<Student_Subject>(S_S);
                            //entr.State = System.Data.Entity.EntityState.Modified;
                            database.SaveChanges();
                        }

                    }
                    

                }
            }
            StudGrid.ItemsSource = null;
            StudGrid.ItemsSource = database.Students.ToList().Join(database.Studies.ToList(), std => std.IdStudies, stud => stud.IdStudies, (std, stud) => new StShow { LastName = std.LastName, FirstName = std.FirstName, IndexNumber = std.IndexNumber, Address = std.Address, Name = stud.Name, id = std.IdStudent, IDStudies = std.IdStudies }).ToList(); ;

        }
    }
}



