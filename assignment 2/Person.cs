namespace SalaryProcessingSystem
{
    class Person
    {
        private string Name { get; set; } 
        private int Age { get; set; }

        public Person() :this("",0)
        {
            
        }
        public Person(String name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Accept()
        {
            Console.WriteLine("Enter Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Age :");
            Age = int.Parse(Console.ReadLine());
        }


        public void Display()
        {
            Console.WriteLine($"Name : {this.Name}, Age : {this.Age}");
        }

    }

    class Emp : Person
    {
        public int Id { get; set; }
        public double Salary { get; set; }

        public Emp() :this("",0,0,0.0)
        {
            
        }

        public Emp(string name, int age, int id, double salary)
            : base(name, age)
        {

            Id = id;
            Salary = salary;
        }

        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Id :");
            this.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary :");
            this.Salary = double.Parse(Console.ReadLine());
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine($"Emp: Id : {this.Id}, Salary : {this.Salary} ");
        }

        public virtual double CalcSal()
        {
            return Salary;
        }

        public static double CalcTotalSal(Emp[] emps) { 
        double total = 0;
            foreach (Emp emp in emps)
            {
                total += emp.Salary;
            }
            return total;
        }

    }
  
    class Labor : Emp
    {
        public int Hours { get; set; }
        public int Rate { get; set; }
        
        public Labor() : this("", 0,0, 0.0, 0 ,0)
        {
            this.Hours = 0;
            this.Rate = 0;
        }
        public Labor(string name, int age, int id, double salary,int hour, int rate ) : base(name, age , id, salary)
        {
            this.Hours = hour;
            this.Rate = rate;
        }

        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Hours :");
            this.Hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate :");
            this.Rate = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine($"Labor: Hours : {this.Hours}, Rate : {this.Rate} ");
        }
        public override double CalcSal()
        {
            return this.Hours * this.Rate;
        }


    }

    class Manager : Emp
    {
        public int Bonus{ get; set; }


        public Manager() : this("", 0, 0, 0.0, 0) 
        {
            this.Bonus = 0;
        }
        public Manager(string name, int age, int id, double salary, int bonus) : base(name, age, id, salary)
        {
          this.Bonus = bonus;
        }

        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Bonus :");
            this.Bonus = int.Parse(Console.ReadLine());
            
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine($"Manager: Bonus : {this.Bonus}");
        }

        public override double CalcSal()
        {
            return this.Salary + this.Bonus;
        }


    }

    class Salesman : Emp
    {
        public int Comm { get; set; }


        public Salesman() : this("", 0, 0, 0.0,0)
        {
            this.Comm = 0;
        }
        public Salesman(string name, int age, int id, double salary, int comm) : base(name, age, id, salary)
        {
            this.Comm= comm;
        }

        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Comm :");
            this.Comm = int.Parse(Console.ReadLine());

        }
        public void Display()
        {
            base.Display();
            Console.WriteLine($"Salesman: Comm : {this.Comm}");
        }

        public override double CalcSal()
        {
            return this.Salary + this.Comm;
        }


    }


    class Clerk : Emp
    {
        public Clerk() : base()
        {
            
        }

        public void Accept()
        {
            base.Accept();
        }
        public void Display()
        {
            base.Display();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person("abc", 50);

            Emp emp = new Emp("bac",50,1,5000);    

            Labor labor = new Labor("cdb", 50, 2, 200,10,500);  

            Manager manager = new Manager("xyz", 50, 3, 20000, 10000);

            Salesman salesman = new Salesman("cvb",45,4,4000,4000);

            Clerk clerk = new Clerk();

            Emp[] emps = new Emp[5] { emp, labor,manager,salesman, clerk };

            Console.WriteLine(Emp.CalcTotalSal(emps));
             

        }
    }
}
