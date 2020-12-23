using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FL_NUMBER.Classes
{
    class Gamer : Player
    {
        public Gamer() {; }
        public void GetNumberb(ref Button firstNumber, ref Button lastNumber)
        {
            firstNumber.Click += GetFirstNumber;
            lastNumber.Click += GetLastNumber;
        }

        private void GetLastNumber(object sender, RoutedEventArgs e)
        {
            List<int> numbers = (List<int>)((Control)sender).Tag;
            UpdateScore(numbers[0]);
            numbers.RemoveAt(0);
        }

        private void GetFirstNumber(object sender, RoutedEventArgs e)
        {
            List<int> numbers = (List<int>)((Control)sender).Tag;
            UpdateScore(numbers[numbers.Count - 1]);
            numbers.RemoveAt(numbers.Count - 1);
        }

        //private void GetFirstNumber(object sender, RoutedEventArgs e)
        //{
        //    gamer_1.UpdateScore(numericalSequence[0]);
        //    numericalSequence.RemoveAt(0);
        //}

        //private void GetLastNumber(object sender, RoutedEventArgs e)
        //{
        //    gamer_1.UpdateScore(numericalSequence[numericalSequence.Count - 1]);
        //    numericalSequence.RemoveAt(numericalSequence.Count - 1);
        //}

        public override void GetNumber(List<int> numbers)
        {
            
        }
    }
}
