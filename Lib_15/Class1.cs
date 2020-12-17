using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_15
{
    public class Class1
    {
        public static void Task(DataGridView table)
        {
            int max = -2147483648;
            for (int i = 0; i < table.ColumnCount; i++)
            {
                for (int j = 0; j < table.RowCount; j++)
                {
                    if (Int32.TryParse(table[i, j].Value.ToString(), out int dop))
                    {
                        if (Convert.ToInt32(table[i, j].Value) > max) max = Convert.ToInt32(table[i, j].Value);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка конвертации! В массиве должны быть целые цифры!");
                    }
                }
            }
            for (int i = 0; i < table.ColumnCount; i++)
            {
                for (int j = 0; j < table.RowCount; j++)
                {
                    if (Convert.ToInt32(table[i, j].Value) < 0) table[i, j].Value = max;
                }
            }
        }
    }
}
