//Разработать класс Fraction, представляющий 
//простую дробь. в классе предусмотреть два поля: мислитель и 
//знаменатель дроби. Выполнить перегрузку следующих операторов: 
//+,-,*,/,==,!=,<,>, true и false.
//Арифметические действия и сравнение выполняется в 
//соответствии с правилами работы с дробями. Оператор true 
//возвращает true если дробь правильная (числитель меньше 
//знаменателя), оператор false возвращает true если дробь 
//неправильная (числитель больше знаменателя).
//Выполнить перегрузку операторов, необходимых для 
//успешной компиляции следующего фрагмента кода:
//Fraction f = new Fraction(3, 4);
//int a = 10;
//Fraction f1 = f * a;
//Fraction f2 = a * f;
//double d = 1.5;
//Fraction f3 = f + d;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCSharp
{
    class Fraction
    {
        public double chisl { get; set; }
        public double znam { get; set; }
        public Fraction() { }
        public Fraction(double chisl, double znam)
        {
            this.chisl = chisl;
            this.znam = znam;
        }
        public static Fraction operator +(Fraction m, Fraction m2)
        {
            return new Fraction
            {
                chisl = (m.chisl * m2.znam) + (m2.chisl * m.znam),
                znam = m.znam * m2.znam
            };
        }
        public static Fraction operator +(Fraction m, double num)
        {
            return new Fraction
            {
                chisl = m.chisl + (num * m.znam),
                znam = m.znam
            };
        }
        public static Fraction operator +(double num, Fraction m)
        {
            return new Fraction
            {
                chisl = m.chisl + (num * m.znam),
                znam = m.znam
            };
        }
        public static Fraction operator -(Fraction m, Fraction m2)
        {
            return new Fraction
            {
                chisl = (m.chisl * m2.znam) - (m2.chisl * m.znam),
                znam = m.znam * m2.znam
            };
        }
        public static Fraction operator -(Fraction m, double num)
        {
            return new Fraction
            {
                chisl = m.chisl - (num * m.znam),
                znam = m.znam
            };
        }
        public static Fraction operator -(double num, Fraction m)
        {
            return new Fraction
            {
                chisl = (num * m.znam) - m.chisl,
                znam = m.znam
            };
        }
        public static Fraction operator *(Fraction m, Fraction m2)
        {
            return new Fraction
            {
                chisl = m.chisl * m2.chisl,
                znam = m.znam * m2.znam
            };
        }
        public static Fraction operator *(Fraction m, double num)
        {
            return new Fraction
            {
                chisl = m.chisl * num,
                znam = m.znam
            };
        }
        public static Fraction operator *(double num, Fraction m)
        {
            return new Fraction
            {
                chisl = m.chisl * num,
                znam = m.znam
            };
        }
        public static Fraction operator /(Fraction m, Fraction m2)
        {
            return new Fraction
            {
                chisl = m.chisl * m2.znam,
                znam = m.znam * m2.chisl
            };
        }
        public static Fraction operator /(Fraction m, double num)
        {
            return new Fraction
            {
                chisl = m.chisl,
                znam = m.znam * num
            };
        }
        public static Fraction operator /(double num, Fraction m)
        {
            return new Fraction
            {
                chisl = m.znam * num,
                znam = m.chisl
            };
        }
        public static bool operator true(Fraction m)
        {
            if (m.chisl < m.znam)
                return true;
            return false;
        }
        public static bool operator false(Fraction m)
        {
            if (m.chisl > m.znam)
                return true;
            return false;
        }
        public static bool operator ==(Fraction m, Fraction m2)
        {
            if (m.chisl / m.znam == m2.chisl / m2.znam)
                return true;
            return false;
        }
        public static bool operator !=(Fraction m, Fraction m2)
        {
            if (m.chisl / m.znam != m2.chisl / m2.znam)
                return true;
            return false;
        }
        public static bool operator ==(Fraction m, double num)
        {
            if (m.chisl / m.znam == num)
                return true;
            return false;
        }
        public static bool operator !=(Fraction m, double num)
        {
            if (m.chisl / m.znam != num)
                return true;
            return false;
        }
        public static bool operator ==(double num, Fraction m)
        {
            if (m.chisl / m.znam == num)
                return true;
            return false;
        }
        public static bool operator !=(double num, Fraction m)
        {
            if (m.chisl / m.znam != num)
                return true;
            return false;
        }
        public static bool operator <(Fraction m, Fraction m2)
        {
            if (m.chisl / m.znam < m2.chisl / m2.znam)
                return true;
            return false;
        }
        public static bool operator >(Fraction m, Fraction m2)
        {
            if (m.chisl / m.znam > m2.chisl / m2.znam)
                return true;
            return false;
        }
        public static bool operator <(Fraction m, double num)
        {
            if (m.chisl / m.znam < num)
                return true;
            return false;
        }
        public static bool operator >(Fraction m, double num)
        {
            if (m.chisl / m.znam > num)
                return true;
            return false;
        }
        public static bool operator <(double num, Fraction m)
        {
            if (m.chisl / m.znam > num)
                return true;
            return false;
        }
        public static bool operator >(double num, Fraction m)
        {
            if (m.chisl / m.znam < num)
                return true;
            return false;
        }
        public override string ToString()
        {
            return $"{chisl}/{znam}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(10, 3);
            Fraction f2 = new Fraction(6, 1);
            WriteLine(f - 6.5);
            ReadKey();
        }
    }
}