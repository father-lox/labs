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

namespace FL_NUMBER.Windows
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            startGame.Click += OpenGameWindow;
            backMainMenu.Click += ShowMainMenu;
        }
        private void OpenGameWindow(object sender, RoutedEventArgs e)
        {
            Int16 rangeNumberFrom = 0;
            Int16 rangeNumberTo = 0;
            string nick = "";
            List<string> listErrors = new List<string>();

            Validation(ref rangeNumberFrom, ref rangeNumberTo, ref nick, listErrors);
            
            if (listErrors.Count > 0)
            {
                string errorMessage = "";
                foreach (string message in listErrors)
                {
                    errorMessage += message + "\n";
                }
                MessageBox.Show(errorMessage);
            }
            else
            {
                new Game(rangeNumberFrom, rangeNumberTo, nick).ShowDialog();
            }
        }

        private void Validation(ref Int16 rangeNumberFrom, ref Int16 rangeNumberTo, ref string nick, List<string> errors)
        {
            try
            {
                rangeNumberFrom = Convert.ToInt16(rangeNumberMin.Text.Trim());
                rangeNumberTo = Convert.ToInt16(rangeNumberMax.Text.Trim());
                nick = nickname.Text.Trim().ToUpper();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message.ToString());
            }

            if (rangeNumberMin.Text.Length == 0 || rangeNumberMax.Text.Length == 0 || nick.Length == 0)
            {
                errors.Add("Все поля формы обязательны для заполнения");
            }
            if (rangeNumberFrom >= rangeNumberTo)
            {
                errors.Add("Диапозон чисел определен неверно");
            }
        }

        private void ShowMainMenu(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
