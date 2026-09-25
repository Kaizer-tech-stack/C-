public class Student
{
    //Defining a Class
    public string Name{ get; set; }
    public string StudentNumber{ get; set;}
    public bool IsIskolar{ get; set; }

    
    //method
    public void Study(){
        Student student1 = new Student();
        Console.WriteLine($"{Name} is studying for their OOP exam");
    }
}