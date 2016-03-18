using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Guess
    {
        private NumberMaker numbermakerMain = new NumberMaker();
        private int answer;
        private byte[] bytesAnswer = new byte[GameLibrary.NumberMaker.NUMBER_SIZE];
        private bool[] boolAnswer = new bool[10];

        public Guess()
        {
            this.MakeNewNumber();
        }

        public void MakeNewNumber()
        {
            bool getanswer;
            do
            {
                this.numbermakerMain.Make();
                getanswer = int.TryParse(this.numbermakerMain.GetAnswer(), out this.answer);
            }
            while (!getanswer);
            this.numbermakerMain.GetNumberData(this.answer, ref this.bytesAnswer, ref this.boolAnswer);
        }

        public string GetAnswer()
        {
            return this.numbermakerMain.GetAnswer();
        }

        public string CheckAnswer(string answer)
        {
            if (answer.Length != GameLibrary.NumberMaker.NUMBER_SIZE)
            {
                return "輸入個數不對!";
            }
            int guess;
            if (false == int.TryParse(answer, out guess))
            {
                return "請輸入數字!";
            }
            byte[] byteGuess = new byte[GameLibrary.NumberMaker.NUMBER_SIZE];
            bool[] boolGuess = new bool[10];
            if (false == this.numbermakerMain.GetNumberData(guess, ref byteGuess, ref boolGuess))
            {
                return "輸入數字有問題!";
            }
            int A = 0, B = 0;
            for (int index = 0; 10 > index; ++index)
            {
                if (true == boolGuess[index] && this.boolAnswer[index] == boolGuess[index])
                {
                    ++B;
                }
            }
            for (int index = 0; GameLibrary.NumberMaker.NUMBER_SIZE > index; ++index)
            {
                if (byteGuess[index] == this.bytesAnswer[index])
                {
                    ++A;
                    --B;
                }
            }
            return string.Format("{2} : {0}A{1}B", A, B, answer);
        }
    }
}