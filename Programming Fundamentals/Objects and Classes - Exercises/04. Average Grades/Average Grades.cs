using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        static void Main()
        {
            int numbersOfStudent = int.Parse(Console.ReadLine());
            List < Students > students= new List<Students>();
            for (int i = 0; i < numbersOfStudent; i++)
            {
                string[] inputTokens = Console.ReadLine().Split().ToArray();
                string nameofStudent = inputTokens[0];
                List<double> grades = new List<double>();
                for (int p = 1; p < inputTokens.Length; p++)
                {
                    double grade = double.Parse(inputTokens[p]);
                    grades.Add(grade);
                }
                Students studnet = new Students();
                studnet.Names = nameofStudent;
                studnet.Grades = grades;
                students.Add(studnet);
            }
            foreach ( Students student in students.Where(x=>x.AverageGrade()>=5).OrderBy(x=>x.Names).ThenByDescending(k=>k.AverageGrade()))
            {
                Console.WriteLine("{0} -> {1:f2}", student.Names,student.AverageGrade());
            }
        }         
    }
    class Students
    {
        public string Names { get; set; }
        public List <double> Grades { get; set; }
        public double AverageGrade()
        {
            double avarageGrade = this.Grades.Average();
            return avarageGrade;
        }

    }
}
