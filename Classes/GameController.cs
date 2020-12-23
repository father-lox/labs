using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FL_NUMBER.Classes
{
    class GameController
    {
        public GameController(Int16 min, Int16 max, UInt16 lengthSequence, UInt16 countGamers)
        {
            this.lengthSequence = lengthSequence;
            this.countGamers = countGamers;
            Random random = new Random();
            for (UInt16 i = 0; i < lengthSequence; i++)
            {
                numericalSequence.Add(random.Next(min, max + 1));
            }
        }

        public void StartGame()
        {
            
        }

        public ref List<int> GetList()
        {
            return ref numericalSequence;
        }

        readonly UInt16 lengthSequence;
        readonly UInt16 countGamers;
        private List<int> numericalSequence = new List<int>();  
    }
}
