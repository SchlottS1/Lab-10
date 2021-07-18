using System;

class Employee {

  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private double yearlysalary;
  private string employmentstatus;

  public string FirstName{get; set;}

  public string LastName{get; set;}

  public int Age {
    get{ return age; }
    set
    {
      if (value < 18)
        age = 18;
      else
        age = value;
    }
  }  
  
  public double YearlySalary {
    get{ return yearlysalary; }
    set 
    {
      if (value < 1000)
        yearlysalary = 1000;
      else
        yearlysalary = value;
    }
  }

  public string Id {get; set;}

  public string EmploymentStatus {get; set;}

  public Employee()
  {
    FirstName = "Unknown";
    LastName = "Unknown";
    Id = "Unknown";
    age = 0;
    EmploymentStatus = "active";
  }

  public Employee(string employfirstname, string employlastname, string employid, int employage, double employyearlysalary)
  {
   FirstName = employfirstname;
   LastName = employlastname;
   Id = employid;
   Age =  employage;
   YearlySalary = employyearlysalary;
  }

  public Employee(string employfirstname, string employlastname, string employid, int employage)
  {
   FirstName = employfirstname;
   LastName = employlastname;
   Id = employid;
   Age =  employage;
  }

  public void Intro()
  {
    Console.WriteLine("First Name: " + FirstName);
    Console.WriteLine("Last Name: " + LastName);
    Console.WriteLine("ID: " + Id);
    Console.WriteLine("Age: " + Age);
  }

  public void IncreaseSalary(double percent)
  {
    if (percent < 0)
    {
    Console.WriteLine("Invalid input. Yearly Salary not updated");
    } else {
      double multiple = (percent / 100) + 1;
      double newsalary = YearlySalary * multiple;
      Console.WriteLine("Yearly salary updated to " + newsalary);
    }
  }

  public void RemoveEmployee()
  {
    if (EmploymentStatus == "inactive")
    {
      Console.WriteLine("Employee already inactive");
    } else {
      EmploymentStatus = "inactive";
      Console.WriteLine("Employee removed successfully!");
    }
  }
  

}