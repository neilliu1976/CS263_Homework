using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class NumberMaker
    {
        public const int NUMBER_SIZE = 4;
        public byte[] answer;
        public Random random;

        public NumberMaker()
        {
            this.random = new Random();
            this.answer = new byte[NUMBER_SIZE];
            for (int index = 0; NUMBER_SIZE > index; ++index)
            {
                this.answer[index] = (byte)0;
            }
        }

        public void Make()
        {
            byte[] number = new byte[10];
            for (int index = 0; 10 > index; ++index)
            {
                number[index] = (byte)(index);
            }
            for (int index = 0; NUMBER_SIZE > index; ++index)
            {
                int random = this.random.Next(0, 10);
                if (random == index)
                {
                    continue;
                }
                byte temp = number[index];
                number[index] = number[random];
                number[random] = temp;
            }
            for (int index = 0; NUMBER_SIZE > index; ++index)
            {
                answer[index] = number[index];
            }
        }

        public string GetAnswer()
        {
            string show = string.Empty;
            StringBuilder strB = new StringBuilder();

            for (int index = 0; index < this.answer.Length; ++index)
            {
                strB.Append(this.answer[index].ToString());
            }
            show = strB.ToString();
            return show;
        }

        public bool GetNumberData(int number, ref byte[] byteArray, ref bool[] boolArray)
        {
            if (NUMBER_SIZE != byteArray.Length || 10 != boolArray.Length)
            {
                return false;
            }
            for (int index = 0; 10 > index; ++index)
            {
                boolArray[index] = false;
            }
            int count = 0;
            for (int index = 0, temp; NUMBER_SIZE > index; ++index)
            {
                temp = number % 10;
                if (!boolArray[temp])
                {
                    boolArray[temp] = true;
                    ++count;
                }
                byteArray[NUMBER_SIZE - index - 1] = (byte)temp;
                number /= 10;
            }
            if (NUMBER_SIZE != count)
            {
                return false;
            }
            return true;
        }
    }
}