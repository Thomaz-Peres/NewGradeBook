using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name) { //quando chamo uma classe como metodo, nao pode ter um return type, like "void" "int";
                        //para nao deixar o codigo implicito, estou colocando a classe como um metodo publico;
            grades = new List<double>();  //iniciando a lista grades do program, de forma correta, assim nao da erro.  

            this.name = name;
        }

        public void AddGrade(double number)
        {
            grades.Add(number); //adding number in grades list
        }

        public Statistics GetStatistcs()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);      //o numero que esta sendo guardado no minGrade é o menor numero da lista number;
                result.High = Math.Max(grade, result.High);    //o numero que esta sendo guardado no highGrade é p maior nunero da lista  number;
                result.Average += grade;
            }
            result.Average /= grades.Count;

            return result;
        }
        
        private List<double> grades;
        private string name;
    }
}