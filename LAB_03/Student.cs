using SchoolManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Student
    {
        private int _studentId;
        public int StudentId { get { return _studentId; } }
        private void _setStudentId(int studentId)
        {
            if (studentId > 0)
            {
                _studentId = studentId;
            }
            else
            {
                throw new Exception("StudentID must be greater than 0");
            }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length > 0)
                {
                    _firstName = value;
                }
                else
                {
                    throw new Exception("Value cannot be empty.");
                }
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value.Length > 0)
                {
                    _lastName = value;
                }
                else
                {
                    throw new Exception("Value cannot be empty.");
                }
            }
        }

        public HashSet<Enrolment> CurrentEnrolments = new HashSet<Enrolment>();

        private DateTime? _registrationDate;

        public DateTime? RegistrationDate { get { return _registrationDate; } }

        public Student(int studentId)
        {
            _setStudentId(studentId);
        }

        public Student(int studentId, string firstName, string lastName)
        {
            _setStudentId(studentId);
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

