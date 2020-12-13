using System;
using System.Collections.Generic;
using System.Text;
using DO;

namespace DALApi
{
    //CRUD Logic
    public interface IDal
    {
        #region Student
        Student getStudent(int id);
        IEnumerable<Student> GetStudents();
        void addStudent(Student s);
        void updateStudent(Student s);
        void deleteStudent(Student s);
        #endregion
    }
}
