using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_NUMBER.Classes
{
    abstract class Player
    {
        public abstract void GetNumber(List<int> numbers);
        public Player()
        {
            score = 0;
        }
        public void UpdateScore(int takenNumber)
        {
            score += takenNumber;
        }
        public int GetScore()
        {
            return score;
        }
        public string GetNickname()
        {
            return nickname;
        }
        public void SetNickname(string nickname)
        {
            this.nickname = nickname;
        }

        protected string nickname;
        protected int score;
    }
}
