using LibVLCSharp.Shared;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MediaPlayer = LibVLCSharp.Shared.MediaPlayer;

namespace FrameTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        LibVLC _libVLC;
        MediaPlayer _mediaPlayer;

        public MainWindow()
        {
            InitializeComponent();

            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);

            //VideoView.Loaded += (sender, e) => VideoView.MediaPlayer = _mediaPlayer;
            VideoView.Loaded += (sender, e) => {

                VideoView.MediaPlayer = _mediaPlayer;

                if (!VideoView.MediaPlayer.IsPlaying)
                {
                    VideoView.MediaPlayer.Play(new Media(_libVLC,
                        @"FrameTest.mp4", FromType.FromPath));
                }
            };

            
        }
    }
}
