using System;

class MainClass {
  public static void Main (string[] args) {
    
    Employee Maria = new Employee("Maria", "Lambert", "S0100", 26, 80000);
    Maria.Intro();
    Console.WriteLine("Yearly Salary " + Maria.YearlySalary);
    Maria.IncreaseSalary(7);
    Maria.RemoveEmployee();
    Maria.RemoveEmployee();
    
    /*Employee John = new Employee("John", "Smith", "S0089", 38, 50000);
    John.Intro();
    Console.WriteLine("Yearly Salary: " + John.YearlySalary);
    John.IncreaseSalary(-2);
    John.RemoveEmployee();*/

   /* Employee Robert = new Employee("Robert", "Downey", "12321", 12);
    Robert.Intro();
    Robert.YearlySalary = 100;
    Console.WriteLine("Yearly Salary: " + Robert.YearlySalary);*/

    /*Employee unknown = new Employee();
    unknown.Intro();*/
  }
}