
namespace AppOOP
{
    class Student
    {
        private string Name;
        public string StName {
            get { return Name; }
            set { }
        }
        public void Student(string StName) { }
        private void btnTalk_Click(object sender, RoutedEventArgs e)
        {
            Student st1 = new Student("Minh");
            Student st = new Student();
            Student st2 = new Student();
            st.Talk();
            st1.Name = "Dung";
            st1.Talk();
        }
    }
}
