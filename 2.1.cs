
using System;

Student sv1 = new Student();
sv1.Name = "Hưng";
sv1.Age = 18;

Student sv2 = new Student();
sv2.Name = "Đậu Anh Hiển";
sv2.Age = 19;

Console.WriteLine(" THONG TIN SINH VIEN ");
Console.WriteLine($"Ten: {sv1.Name}, Tuoi: {sv1.Age}");
Console.WriteLine($"Ten: {sv2.Name}, Tuoi: {sv2.Age}");

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
