using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaUSaveEditor.Helper
{
    public static class ArrayHelper
    {
        public static byte[] RemoveRange(byte[] data, int index, int length)
        {
            var buffer = data.ToList();
            buffer.RemoveRange(index, length);

            return buffer.ToArray();
        }

        public static byte[] AddRangeAtIndex(byte[] data, byte[] extraData, int index)
        {
            var buffer = data.ToList();
            buffer.InsertRange(index, extraData.ToList());

            return buffer.ToArray();
        }

        public static byte[] ColorToByteArray(Color color)
        {
            byte[] colorArray = new byte[3];
            colorArray[0] = color.R;
            colorArray[1] = color.G;
            colorArray[2] = color.B;

            return colorArray;
        }
    }
}
