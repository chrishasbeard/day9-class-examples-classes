using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassExample
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string major;
        private double gpa;
        private string email;

        #region properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }

        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        public Student()
        {

        }

        public Student (string _firstName, string _lastName, string _major, string _email, double _gpa)
        {
            firstName = _firstName;
            lastName = _lastName;
            major = _major;
            email = _email;
            gpa = _gpa;
        }

        public Student (string _firstName, string _lastName, string _email)
        {
            firstName = _firstName;
            lastName = _lastName;
            email = _email;
        }
    }
}
