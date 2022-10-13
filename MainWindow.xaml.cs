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
using System.IO;

namespace VLC_Camera
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            VLC1A.MediaPlayer.VlcLibDirectory = new DirectoryInfo(@"D:\VLC media\VLC\");
            VLC1A.MediaPlayer.EndInit();
            VLC1A.MediaPlayer.Play(new Uri(@"dshow://"));
            //VLC2A.MediaPlayer.VlcLibDirectory = new DirectoryInfo(@"D:\VLC media\VLC\");
            //VLC2A.MediaPlayer.EndInit();
            //VLC2A.MediaPlayer.Play(new Uri(@"dshow://"));
            //VLC3A.MediaPlayer.VlcLibDirectory = new DirectoryInfo(@"D:\VLC media\VLC\");
            //VLC3A.MediaPlayer.EndInit();
            //VLC3A.MediaPlayer.Play(new Uri(@"dshow://"));
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
