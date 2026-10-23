
using System;

Student student1 = new Student("Đậu Anh Hiển", 19);
Student student2 = new Student("Hưng", 20);

Console.WriteLine("THONG TIN SINH VIEN");
student1.DisplayInfo();
student2.DisplayInfo();

Console.WriteLine("Tuoi sau khi gan gia tri khong hop le:");
Console.WriteLine(student1.Age);

public class Student
{
    public string Name { get; set; }

    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Tuoi phai lon hon 0!");
            }
        }
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Ten: {Name}");
        Console.WriteLine($"Tuoi: {Age}");
    }
}
