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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;

namespace CPianoSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayNote(object sender, RoutedEventArgs e)
        {
            Button Key = sender as Button;

            using (SoundPlayer player = new SoundPlayer())
            {
                player.SoundLocation = @"AUDIO\" + Key.Name + "3.wav";
                player.Play();
            }
        }
    }
}
