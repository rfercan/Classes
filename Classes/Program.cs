// See https://aka.ms/new-console-template for more information

Course course1 = new Course();
course1.Id = 1;
course1.Name = "C";
course1.Instructor = "Tom";

Course course2= new Course();
course2.Id= 2;
course2.Name = "C+";
course2.Instructor = "Jerry";

//Console.WriteLine(course1.Name +" : "+ course1.Instructor);

Course[] courses= new Course[] { course1,course2};
foreach (var course in courses)
{
    Console.WriteLine(course.Name + ": "+ course.Instructor);
}
class Course
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Instructor { get; set; }

}
