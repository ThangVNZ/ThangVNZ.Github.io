using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace AppOOP
{
    class Student
    {
        
        public string StudentName;
        public class RoutedEventArgs : EventArgs {
            
        }
        private void btnTalk_Click(object sender, RoutedEventArgs e)
        {
            Student st1 = new Student();
            Student st = new Student();
            Student st2 = new Student();
            st.btnTalk_Click();
            st1.StudentName = "Dung";
            st1.btnTalk_Click();
        }

        private void btnTalk_Click()
        {
            
        }
    }
}
