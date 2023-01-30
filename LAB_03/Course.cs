using SchoolManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Course
    {
        private int _courseId;
        public int CourseId { get { return _courseId; } }
        private void _setCourseId(int courseId)
        {
            if (courseId > 99)
            {
                _courseId = courseId;
            }
            else
            {
                throw new Exception("Course ID should be a number greater than 100");
            }
        }

        private string _title;
        public string Title { get { return _title; } }
        private void _setTitle(string title)
        {
            if (title.Length > 3)
            {
                _title = title;
            }
            else
            {
                throw new Exception("Title should be 3 or more characters long");
            }
        }

        private int _capacity;
        public int Capacity { get { return _capacity; } }
        private void _setCapacity(int capacity)
        {
            if (capacity > 0)
            {
                _capacity = capacity;
            }
            else
            {
                throw new Exception("Capacity must be greater than 0");
            }
        }

        private HashSet<Enrolment> _enrolments = new HashSet<Enrolment>();

        public void AddEnrolment(Enrolment enrolment)
        {
            _enrolments.Add(enrolment);
        }

        public HashSet<Enrolment> GetEnrolments()
        {
            HashSet<Enrolment> setCopy = _enrolments.ToHashSet();
            return setCopy;
        }

        public void RemoveEnrolment(Enrolment enrolment)
        {
            _enrolments.Remove(enrolment);
        }

        public Course(int courseId, string title, int capacity)
        {
            _setCourseId(courseId);
            _setTitle(title);
            _setCapacity(capacity);
        }
    }
}
