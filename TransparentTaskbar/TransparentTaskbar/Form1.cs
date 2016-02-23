using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TransparentTaskbar
{
    public partial class Form1 : Form
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


        public Form1()
        {
            InitializeComponent();



            GetWindowCompositionAttribute()
        }
    }
}
