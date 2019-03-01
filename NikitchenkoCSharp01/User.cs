using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NikitchenkoCSharp01
{
    class User
    {
        private DateTime _dateOfBirth;
        private string _zodiacW;
        private string _zodiacC;
        private string _age;
        private bool _happyBDay;

        internal User()
        {
            _dateOfBirth = DateTime.Today;
        }
        internal DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                _dateOfBirth = value;
                int days = (DateTime.Today - _dateOfBirth).Days;
                var age = days / 365;

                if (days > 0 && age < 135)
                {
                    Age = age.ToString();
                    _happyBDay = HappyBDay();
                    _zodiacC = Zodiac();
                    _zodiacW = ZodiacC();
                    if (_happyBDay)
                    {
                        MessageBox.Show("З днем народження!");
                    }
                }
            }
        }


            public string Age
        {
            get { return _age; }
            set
            {
                _age = value;
            }
        }

        public string ZodiacWest
        {
            get { return _zodiacW; }
            set
            {
                _zodiacW = value;
            }
        }

        public string ZodiacChina
        {
            get { return _zodiacC; }
            set
            {
                _zodiacC = value;
            }
        }
        private bool HappyBDay()
        {
            return DateTime.Today.DayOfYear == _dateOfBirth.DayOfYear;
        }
        private String ZodiacC()
        {
            int sign = _dateOfBirth.Year % 12;
            switch (sign)
            {
                case 0:
                    return "Рік Мавпи";

                case 1:
                    return "Год Півня";
                case 2:
                    return "Рік Собаки";
                case 3:
                    return "Рік Свині";
                case 4:
                    return "Рік Пацюка";
                case 5:
                    return "Рік Бика";
                case 6:
                    return "Рік Тигра";
                case 7:
                    return "Рік Кролика";
                case 8:
                    return "Рік Дракона";
                case 9:
                    return "Рік Змії";
                case 10:
                    return "Рік Коня";
                case 11:
                    return "Рік Кози";

            }
            return "";
        }
        private string Zodiac()
        {
            var day = _dateOfBirth.Day;
            var month = _dateOfBirth.Month;
            if (day == -1)
                return "Error Code -1";
            if (day > 21 && month == 12 || day < 20 && month == 1)
                return "Козерог";
            else if (day > 19 && month == 1 || day < 19 && month == 2)
                return "Водолій";
            else if (day > 18 && month == 2 || day < 21 && month == 3)
                return "Риби";
            else if (day > 20 && month == 3 || day < 20 && month == 4)
                return "Овен";
            else if (day > 19 && month == 4 || day < 21 && month == 5)
                return "Телець";
            else if (day > 20 && month == 5 || day < 21 && month == 6)
                return "Близнюки";
            else if (day > 20 && month == 6 || day < 23 && month == 7)
                return "Рак";
            else if (day > 22 && month == 7 || day < 23 && month == 8)
                return "Лев";
            else if (day > 22 && month == 8 || day < 23 && month == 9)
                return "Діва";
            else if (day > 22 && month == 9 || day < 23 && month == 10)
                return "Терези";
            else if (day > 22 && month == 10 || day < 22 && month == 11)
                return "Скорпіон";
            else if (day > 21 && month == 11 || day < 22 && month == 12)
                return "Стрілець";
            else
                return "Козеріг";

        }
    }
}
