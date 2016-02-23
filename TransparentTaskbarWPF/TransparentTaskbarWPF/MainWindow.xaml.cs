using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TransparentTaskbarWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public struct WINCOMPATTRDATA
        {
            UInt32 attribute; // the attribute to query, see below
            IntPtr pData; // buffer to store the result
            ulong dataSize; // size of the pData buffer
        };

        [DllImport("user32.dll")]
        public static extern bool GetWindowCompositionAttribute(IntPtr hWnd, WINCOMPATTRDATA pAttrData);

        [DllImport("user32.dll")]
        public static extern bool SetWindowCompositionAttribute(IntPtr hWnd, WINCOMPATTRDATA pAttrData);

        public MainWindow()
        {
            InitializeComponent();

            Window window = Window.GetWindow(this);
            var wih = new WindowInteropHelper(window);
            IntPtr hWnd = wih.Handle;

            Console.WriteLine("Debug");
            Console.Write(hWnd);
        }
    }
}
