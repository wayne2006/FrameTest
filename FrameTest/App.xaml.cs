using System.Windows;
using LibVLCSharp.Shared;

namespace FrameTest
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Core.Initialize();
        }
    }
}
