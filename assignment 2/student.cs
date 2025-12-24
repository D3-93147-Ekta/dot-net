namespace Assignment2Q2
{

    struct Student
    {
        //public string Name {  get; set; }
        //public bool Gender { get; set; }
        //public int Age { get; set; }
        //public int Std { get; set; }
        //public char Div { get; set; }

        //public double Marks { get; set; }

        string _name;
        bool _gender;
        int _age;
        int _std;
        char _div;
        double _marks;

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public bool Gender
        {
            get
            {
                return this._gender;
            }
            set
            {
                this._gender = value;
            }
        }

        public int Age
        {
            get
            {
                return this._age;
            }
            set { this._age = value; }
        }
        public int Std
        {
            get
            {
                return this._std;
            }
            set
            {
                this._std = value;
            }
        }
        public char Div
        {
            get
            {
                return this._div;
            }
            set
            {
                this._div = value;

            }
        }
        public double Marks
        {
            get
            {
                return this._marks;
            }
            set
            {
                this._marks = value;
            }
        }
        


        public Student()
        {

        }

        public Student(string name, bool gender, int age, int std, char div, double Marks)
        {
            this._name = name;
            this._gender = gender;
            this._age = age;
            this._std = std;
            this._div = div;
            this._marks = Marks;

        }

       


        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name :");
            this._name = Console.ReadLine();
            Console.WriteLine("Enter Gender :");
            this._gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter Age :");
            this._age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Std :");
            this._std = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Div :");
            this._div = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks :");
            this._marks = double.Parse(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name : {this._name} Gender : {this._gender} Age : {this._age} Std : {this._std} Div : {this._div} Marks : {this._marks} ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //by default access specifier of structure members are private
            
        }
    }
}
