// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()

    {
        Employee employee = new Employee();
        Console.WriteLine("----------------------");
        Console.WriteLine("Employee Bonus Checker");
        Console.WriteLine("----------------------");
        for(int i = 0;i < 2;i++){
            Console.WriteLine("");
        }
        Console.Write("Enter Name: ");
        employee.Name = Console.ReadLine();
        Console.Write("Enter Salary: ");
        employee.Salary = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Perfomance(1 - 5): ");
        employee.Perfomance = Convert.ToInt32(Console.ReadLine());
        employee.getBonus();
        employee.getSalaryTotal();
        
    }

}
class Employee{

    public string Name{get;set;}
    public int Salary{get;set;}
    public int Perfomance{get;set;}
    public int Bonus{get;set;}
    public Employee(){
        Name = "default";
        Bonus = 0;
        Perfomance = 0;
        Salary = 0;
    }
    public void getBonus(){
        if(Perfomance == 5){
            Bonus = (Salary / 100) * 20;
        }else if(Perfomance == 4){
            Bonus = (Salary / 100) * 10;
        }else if(Perfomance == 3){
            Bonus = (Salary / 100) * 5;
        }else{
            Bonus = 0;
        }
        Console.WriteLine($"Bonus : {Bonus}$ ");

    }
    public void getSalaryTotal(){
        Console.WriteLine($"Total salary : {Salary + Bonus}$");
    }

}