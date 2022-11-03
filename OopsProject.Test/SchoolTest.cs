using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopsProject;
using System.Runtime.InteropServices;

namespace OopsProject.Test
{
    
    public class SchoolTest
    {
        Student s = new Student();
        Teacher t = new Teacher();
        Subject sub = new Subject();

        public SchoolTest()
        {
            s.FileRead();
        }

        [TestCase("Bhavya", ExpectedResult =true)]
        [TestCase("bhavya", ExpectedResult =true)]
        [TestCase("Kanye", ExpectedResult =true)]
        [TestCase("kanye", ExpectedResult =false)]

        public bool FindStudent(string ans)
        {
            return s.SearchByName(ans);
        } 
        [TestCase("Drake", ExpectedResult =true)]
        [TestCase("Travis", ExpectedResult =true)]
        [TestCase("Abel", ExpectedResult =true)]
        [TestCase("Mac", ExpectedResult =false)]

        public bool FindTeacher(string ans)
        {
            return t.SearchByName(ans);
        } 
        [TestCase("Chemistry", ExpectedResult =true)]
        [TestCase("bhavya", ExpectedResult =false)]
        [TestCase("Biology", ExpectedResult =true)]
        [TestCase("Physics", ExpectedResult =false)]

        public bool FindSubject(string ans)
        {
            return sub.SearchByName(ans);
        }
        

    }
}
