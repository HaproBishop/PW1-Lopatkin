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
        public static int maxvalue;
        public static string Find_MaxValue(int n)
        {
            maxvalue = 0;
            Random rnd = new Random();
            int value1 = 0, value2 = 0;
            string values = "";
            for (int i = 0; i < n; i++)
            {
                if (i % 2.0 == 0) //Условие - проверка четности порядка числа (например, 2 - остатка не будет(0), следовательно - четное число при делении на 2)
                { //Задавание первого числа и его добавление в строку 
                    value1 = rnd.Next(n);
                    values += Convert.ToString(value1) + " ";
                }
                if (i % 2.0 != 0) //Условие - проверка четности порядка числа (например, 3 - остаток будет(1), следовательно - нечетное число при делении на 2)
                {//Задавание второго числа и его добавление в строку
                    value2 = rnd.Next(n);
                    values += Convert.ToString(value2) + " ";
                }
                if (value1 > maxvalue) maxvalue = value1; //Сравнение числа и максимума
                if (value2 > maxvalue) maxvalue = value2;
            }            
            return values;
        }
    }
}
