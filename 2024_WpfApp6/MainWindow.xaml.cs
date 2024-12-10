using System.Windows;

namespace _2024_WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Course> courses = new List<Course>();
        List<Record> records = new List<Record>();
        public MainWindow()
        {
            InitializeComponent();
            InitailizeData();
        }

        private void InitailizeData()
        {
            // 新增學生資料，連結至cmbstudent
            students.Add(new Student { StudentId = "S001", StudentName = "陳曉明" });
            students.Add(new Student { StudentId = "S002", StudentName = "黃小美" });
            students.Add(new Student { StudentId = "S003", StudentName = "王大同" });
            cmbStudent.ItemsSource = students;
            cmbStudent.SelectedIndex = 0;

            // 新增教師資料以及所教授課程
            Teacher teacher1 = new Teacher("陳定宏");
            teacher1.TeachingCourses.Add(new Course
            { CourseName = "視窗程式設計", OpeningClass = "四技資工二甲", Point = 3,Tutor = teacher1, Type = "選修" });
            teacher1.TeachingCourses.Add(new Course
            { CourseName = "網頁程式設計", OpeningClass = "四技資工二甲", Point = 3, Tutor = teacher1, Type = "選修" });
            teacher1.TeachingCourses.Add(new Course
            { CourseName = "資料庫系統", OpeningClass = "四技資工二乙", Point = 3, Tutor = teacher1, Type = "選修" });
            teachers.Add(teacher1);

            Teacher teacher2 = new Teacher("林志玲");
            teacher2.TeachingCourses.Add(new Course
            { CourseName = "資料結構", OpeningClass = "四技資工二甲", Point = 3, Tutor = teacher2, Type = "選修" });
            teacher2.TeachingCourses.Add(new Course
            { CourseName = "作業系統", OpeningClass = "四技資工二甲", Point = 3, Tutor = teacher2, Type = "選修" });
            teacher2.TeachingCourses.Add(new Course
            { CourseName = "網路程式設計", OpeningClass = "四技資工二乙", Point = 3, Tutor = teacher2, Type = "選修" });
            teachers.Add(teacher2);

            Teacher teacher3 = new Teacher("張學友");
            teacher3.TeachingCourses.Add(new Course
            { CourseName = "資料結構", OpeningClass = "四技資工二甲", Point = 3, Tutor = teacher3, Type = "選修" });
            teacher3.TeachingCourses.Add(new Course
            { CourseName = "作業系統", OpeningClass = "四技資工二甲", Point = 3, Tutor = teacher3, Type = "選修" });
            teacher3.TeachingCourses.Add(new Course
            { CourseName = "網路程式設計", OpeningClass = "四技資工二乙", Point = 3, Tutor = teacher3, Type = "選修" });
            teachers.Add(teacher3);


            tvTeacher.ItemsSource = teachers;
        }   

    }
}