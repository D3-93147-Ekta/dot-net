using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;

        public Student() { }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public string getName() { return name; }
        public int getAge() { return age; } 
        public int getStd() { return std; } 
        public char getDiv() { return div; }
        public bool getGender() { return gender; }
        public double getMarks() { return marks;}
        public void setAge(int age) {  this.age = age; }
        public void setStd(int std) {  this.std = std; }
        public void setDiv(char div) {  this.div = div; }
        public void setMarks(double marks) {  this.marks = marks; }
        public void setGender(bool gender) {  this.gender = gender; }

        public void AcceptRecord()
        {
            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("enter gender");
            gender = bool.Parse(Console.ReadLine());

            Console.WriteLine("enter std");
            std = int.Parse(Console.ReadLine());

            Console.WriteLine("enter div");
            div = char.Parse(Console.ReadLine());

            Console.WriteLine("enter marks");
            marks = double.Parse(Console.ReadLine());
        }

        public void DisplayRecord()
        {
            Console.WriteLine("name :" + this.name);
            Console.WriteLine("age :" + this.age);
            Console.WriteLine("gender :" + this.gender);
            Console.WriteLine("std: "+ this.std);
            Console.WriteLine("div: " + this.div);
            Console.WriteLine("marks: "+ this.marks);
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptRecord();
            student.DisplayRecord();    
        }
    }
}
