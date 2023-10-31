using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object_day2_homework
{
    //--- Exercise 4 ---
    //Class: Student
    //For the purpose of this exercise, a student has a name and a test score based on the tests they've taken.
    //- 'AddTest(score)'
    //- 'GetTotalScore()'
    //- 'GetAverageScore()'
    //Which variables does your class need when you construct it?
    //Implement the class and create an object to test it!
    internal class Student
    {
       
            int totalScore;
            int totalTests;
            public string Name { get; set; }
        public Student(){ }
            public Student(string name)
            {
                totalScore = 0;
                totalTests = 0;
                Name = name;
            }
            public int AddTest(int score)
            {
                totalScore += score;
            totalTests++;
               return score;
            }
            public int GetTotalScore()
            {
                return totalScore;
            }
            public double GetAverageScore()
            {
                return (double)totalScore / totalTests;

            }

        
    }
}