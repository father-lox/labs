using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FL_NUMBER.Classes;

namespace FL_NUMBER.Windows
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public Game(Int16 minNumber, Int16 maxNumber, string nick)
        {
            InitializeComponent();
            gamer_1.SetNickname(gamerNick.Text = nick);
            bot_1.SetNickname(botNick.Text = "bot_1".ToUpper());
            Random random = new Random();
            for (int i = 0; i < lengthSequence; i++)
            {
                numericalSequence.Add(random.Next(minNumber, maxNumber + 1));
            }
            UpdateScene(numericalSequence, gamer_1.GetScore(), bot_1.GetScore());
            buttonGetFirstNumber.Tag = buttonGetLastNumber.Tag = numericalSequence;
            //buttonGetFirstNumber.Click += GetFirstNumber;
            //buttonGetLastNumber.Click += GetLastNumber;

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

        private void UpdateScene(List<int> numbers, int scoreGamer, int scoroBot)
        {
            listNumbers.ItemsSource = null;
            listNumbers.ItemsSource = numbers;
            gamerScore.Text = Convert.ToString(scoreGamer);
            botScore.Text = Convert.ToString(scoroBot);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            while (numericalSequence.Count > 4)
            {
                bot_1.GetNumber(numericalSequence);
                UpdateScene(numericalSequence, gamer_1.GetScore(), bot_1.GetScore());
                gamer_1.GetNumberb(ref buttonGetFirstNumber, ref buttonGetLastNumber);
                UpdateScene(numericalSequence, gamer_1.GetScore(), bot_1.GetScore());
            }
        }

        private const int lengthSequence = 10;
        private const int countGamers = 2;
        private List<int> numericalSequence = new List<int>();
        Bot bot_1 = new Bot();
        Gamer gamer_1 = new Gamer();
    }
}
