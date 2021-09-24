using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Поиск максимума среди 2-х чисел:
//void Find_MaxValue(int value1, int value2, ref int maxvalue)
//Параметры:
//int value1 - первое число
//int value2 - второе число
//int maxvalue - текущий максимум (0 - по умолчанию)
//Возвращаемое значение:
//int maxvalue - новое значение максимума
namespace Lib_8
{
    public class Class_Lib_8
    {
        public static void Find_MaxValue(int value1, int value2, ref int maxvalue)
        {
            if (maxvalue < value1) maxvalue = value1;
            if (maxvalue < value2) maxvalue = value2;
        }
    }
}
