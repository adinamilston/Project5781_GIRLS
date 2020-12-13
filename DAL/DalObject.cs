using System;
using System.Collections.Generic;
using System.Text;
using DALApi;
using DO;
using DS;

namespace DAL
{
    internal sealed class DalObject : IDal
    {
        #region singelton
        //create instance
        static DalObject instance;
        public static DalObject Instance
        {
            get
            {
                if (instance == null)
                    instance = new DalObject();
                return instance;
            }
        }
        //static ctor
        static DalObject() { }
        //private ctor
        private DalObject() { }
        #endregion
        public void addStudent(Student s)
        {
                DataSource.students.Add(s);
            }

        public Student getStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public void updateStudent(Student s)
        {
            throw new NotImplementedException();
        }

        public void deleteStudent(Student s)
        {
            throw new NotImplementedException();
        }
    }

        public void deleteStudent(Student s)
        {
            throw new NotImplementedException();
        }

        public Student getStudent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        public void updateStudent(Student s)
        {
            throw new NotImplementedException();
        }
    }
}
