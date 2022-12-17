using System;
namespace Examples;
public  class Person{
    public String Name;
    public int Age;
public Person(){}
   public Person (String name,int age){
    Name=name;
    Age=age;
   }
   public virtual void print (){
    Console.WriteLine($"my name is {Name} , my age is {Age}");
   }

   
}
public class Student : Person {
    public String Name;
    public int Age;
   public int Year;
   public float Gpa;
 public Student(String name,int age,int year,float gpa):base(name,age)
 {
    Year=year;
    Gpa=gpa;
 }
 public override void print(){
    Console.WriteLine($"My name is {Name},My age is {Age} ,and my gpa {Gpa}");
 }
}
public class Database{
    private int _currentindex;
    public Person []People=new Person[50];
    public void Addstudent(Student student){
        People[_currentindex++]=student;
    }
    public void Addperson(Person person){
        People[_currentindex++]=person;
    }
    
     public void Addstaff(Staff staff){
        People[_currentindex++]=staff;
    }
    public void printall(){
        for(var i=0;i<_currentindex;i++){
            People[i].print();
        }
    }
}

public class Staff : Person {
    public double Salary;
    public int JoinYear;
    public Staff(String name,int age,double salary,int joinyear):base(name,age){
        Salary=salary;
        JoinYear=joinyear;
    }
    public override void print()
    {
     Console.WriteLine($"My name is {Name},My age is {Age} ,and my salary {Salary}");

    }
}
public class Program{
    public static void Main(){
        var database=new Database();
        while(true){
            Console.WriteLine("1 to student 2 to staff 3 to person 4 to print all");
            var option=Convert.ToInt32(Console.ReadLine());
            switch (option){
                case 1:
                Console.Write("name :");
                var name=Console.ReadLine();
                Console.Write("age :");
               var age=Convert.ToInt32(Console.ReadLine()); 
               Console.Write("year :");
              var year=Convert.ToInt32(Console.ReadLine());
             Console.Write("gpa :");
             var gpa=Convert.ToSingle(Console.ReadLine());

        var student=new Student(name,age,year,gpa);

        database.Addstudent(student);
                break;
                case 2:
         Console.Write("name :");
        var name1=Console.ReadLine();
        Console.Write("age :");
        var age1=Convert.ToInt32(Console.ReadLine()); 
        Console.Write("salary:");
        var salary=Convert.ToInt32(Console.ReadLine());
        Console.Write("year :");
        var joinyear=Convert.ToInt32(Console.ReadLine());

        var staff=new Staff(name1,age1,salary,joinyear);

        database.Addstaff(staff);
                break;
                case 3:
                 Console.Write("name :");
        var name2=Console.ReadLine();
        Console.Write("age :");
        var age2=Convert.ToInt32(Console.ReadLine());
         var person=new Person(name2,age2);
         database.Addperson(person);
                break;
                case 4:
               database.printall();
                break;
                default:
                return;
            }
        }

    }

}
