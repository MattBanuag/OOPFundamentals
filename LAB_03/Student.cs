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
        // STUDENT ID
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

        // FIRSTNAME
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

        // LASTNAME
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

        // Many students can each take one course
        public Course Course { get; set; }

        // REGISTRATION DATE
        private DateTime? _registrationDate;

        public DateTime? RegistrationDate { get { return _registrationDate; } }

        public void SetRegistrationDate()
        {
            _registrationDate = DateTime.Now;
        }

        // COURSE GRADE
        private int? _courseGrade;
        public int? CourseGrade { get { return _courseGrade; } }

        public void SetCourseGrade(int grade)
        {
            if (Course == null)
            {
                throw new Exception("Student is not enrolled in any course");
            }
            else if (grade <= 0 || grade > 100)
            {
                throw new Exception("Grade must be between 0 and 100");
            }
            else
            {
                _courseGrade = grade;
            }
        }

        public void RemoveGrade()
        {
            _courseGrade = null;
            _registrationDate = null;
        }

        // CONSTRUCTOR
        public Student(int studentId)
        {
            _setStudentId(studentId);
        }

        public Student(int studentId, string firstName, string lastName)
        {
            _setStudentId(studentId);
            // If we define public set methods on properties, we should ONLY use those to change the value of a field, so that we user their validation
            FirstName = firstName;
            LastName = lastName;

            // If we use a field to change a value, we do not valdate.
            // Avoid direct assignment to a field(e.g _lastName = lastName)
        }
    }
}
