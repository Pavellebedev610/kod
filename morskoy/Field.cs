using System;
using System.Collections.Generic;
using System.Text;

namespace morskoyboy
{
    public class Field
    {
        private byte[,] cells = new byte[10, 10];
        public byte GetCellsValue(byte x, byte y)
        {
            return cells[x, y];
        }
        public bool SetCellValue 
    }
}
