using SchoolManagement;

int courseNum = School.CreateCourse("Software Developer", 12);
int studentNum = School.CreateStudent("John", "Doe");

try
{
    School.EnrolStudent(studentNum, courseNum);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Argument Exception");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    School.UnEnrollStudent(studentNum, courseNum);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}