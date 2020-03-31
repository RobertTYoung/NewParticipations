using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes
{
    class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public String Text { get; set; }


        public TextBox()
        {
            Padding = 0;
            BackColor = 0;
            ForeColor = 0;
            Text = " ";
        }
        public void DisplayText()
        {

        }

    }
}
