using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCalculationLibrary
{
    public class ScoreMaker
    {
        private static string[] subjects = new string[3] { "國文", "英文", "數學" };

        private Student student;
        private string name;
        private int[] scores;

        public ScoreMaker()
        {
            this.scores = new int[3] { 0, 0, 0 };
        }

        private void GetStudentName()
        {
            this.MessageOut("請輸入姓名:");
            this.name = this.MessageIn();
        }

        private void GetScore()
        {
            string message;
            for (int index = 0; 3 > index; ++index)
            {
                do
                {
                    message = string.Format("請輸入{0}成績:", ScoreMaker.subjects[index]);
                    this.MessageOut(message);
                } while (!int.TryParse(this.MessageIn(), out this.scores[index]));
            }
        }

        private void MessageOut(string message)
        {
            Console.Write(message);
        }

        private string MessageIn()
        {
            return Console.ReadLine();
        }

        public void Run()
        {
            this.GetStudentName();
            this.GetScore();
            student = new Student(this.name, this.scores[0], this.scores[1], this.scores[2]);
            this.MessageOut(student.ToString());
        }
    }
}