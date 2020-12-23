using System.Collections.Generic;

namespace FL_NUMBER.Classes
{
    class Bot : Player
    {
        public Bot() {; }
    
        public override void GetNumber(List<int> numbers)
        {
            int value = 0;
            if (numbers[0] > numbers[numbers.Count - 1])
            {
                value = numbers[0];
                numbers.RemoveAt(0);
            }
            else
            {
                value = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            UpdateScore(value);
        }
    }
}
