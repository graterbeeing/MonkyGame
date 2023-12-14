using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkyGame
{
    internal class Game
    {
        Random rnd = new Random();
        private int type = 0;
        private int num1;
        private int num2;

        public Game(int type)
        {
            this.type = type;
        }
        
        public void CreateNumbers()
        {
            num1 = rnd.Next(0,11);
            num2 = rnd.Next(0,11);
        }

        public string CreateOporator()
        {
            switch (type)
            {
                case 0:
                    return "+";
                case 1:
                    break;
                //...
            }
            return "+";
        }

        public bool CheckAnswer(string answerTxt)
        {
            int answer = int.Parse(answerTxt);
            // it would have a switch statment if we had more than one oporator
            return answer == num1+num2;
        }

        public void SetType(int type)
        {
            this.type = type;
        }

        public int GetNum1()
        {
            return num1;
        }

        public int GetNum2()
        {
            return num2;
        }

        public int getType()
        {
            return type;
        }
    }
}
