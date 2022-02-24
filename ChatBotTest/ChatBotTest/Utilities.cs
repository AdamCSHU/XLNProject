using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ChatBotTest
{
    public static class Utilities
    {
        public static int GetHeightText(Label label)
        {
            using (Graphics graphic = label.CreateGraphics())
            {
                SizeF size = graphic.MeasureString(label.Text, label.Font, 495);
                return (int)Math.Ceiling(size.Height);
            }
        }
    }
}
