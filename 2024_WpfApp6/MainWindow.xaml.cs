using System.Windows;

namespace _2024_WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            InitailizeData();
        }

        private void InitailizeData()
        {
            students.Add(new Student { StudentId = "S001", StudentName = "陳曉明" });
            students.Add(new Student { StudentId = "S002", StudentName = "黃小美" });
            students.Add(new Student { StudentId = "S003", StudentName = "王大同" });

            cmbStudent.ItemsSource = students;
            cmbStudent.SelectedIndex = 0;
        }
    }
}