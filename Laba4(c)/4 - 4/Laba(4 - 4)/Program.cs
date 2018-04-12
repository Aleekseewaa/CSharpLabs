using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4___4_
{
    class Student
    {
        private
                string name;
        int sumb;
        Random random = new Random();

        public void SetValue(string name)
        {
            this.name = name;
            this.sumb = random.Next(0, 100);
        }

        public new void ToString()
        {
            Console.WriteLine("Имя: " + this.name);
            Console.WriteLine("Набранные баллы: " + this.sumb);
        }

        public static Student[] InitAr(Student[] stud)
        {
            for (int i = 0; i < stud.Length; i++) stud[i] = new Student();
            return stud;
        }
    }

    class Laba4
    {
        static void Main(string[] args)
        {
            Student[] stud = new Student[3];
            Student.InitAr(stud);
            stud[0].SetValue("Julia Alekseewa");
            stud[0].ToString();
        }
    }
}