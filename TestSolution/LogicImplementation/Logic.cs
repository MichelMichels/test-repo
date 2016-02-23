using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicImplementation
{
    class LogicImplementation
    {
        public Logic()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);

            Point p = Cursor.Position;
            labelXCoordinate.Text = $"{p.X}";
            labelYCoordinate.Text = $"{p.Y}";

            Console.WriteLine("Test");
        }

        public void RefreshPosition()
        {
            System.Threading.Thread.Sleep(1000);

            Point p = Cursor.Position;
            labelXCoordinate.Text = $"{p.X}";
            labelYCoordinate.Text = $"{p.Y}";


            Console.WriteLine("RefreshPosition");
            RefreshPosition();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            RefreshPosition();
        }
    }
}
