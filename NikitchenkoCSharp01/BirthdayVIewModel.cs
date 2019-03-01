using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace NikitchenkoCSharp01
{
    class BirthdayVIewModel : INotifyPropertyChanged
    {
        private readonly User user = new User();

        public string Age
        {
            get
            {
                return $"Твій вік {user.Age}";
            }
        }
        public string ZodiacWest
        {
            get
            {
                return $"Ваш західний знак: {user.ZodiacWest}";
            }

        }
        public string ZodiacChinese
        {
            get
            {
                return $"Ваш китайський знак: {user.ZodiacChina}";
            }
           
        }
        public DateTime DateOfBirth
        {
            get { return user.DateOfBirth; }
            set
            {
                user.DateOfBirth = value;
                int days = (DateTime.Today - user.DateOfBirth).Days;
                var age = days / 365;
                try
                {
                    if (days < 0 || age > 135)
                    {
                        MessageBox.Show("Неправильна дата!!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Неправильна дата!!");
                }
                OnPropertyChanged();
                OnPropertyChanged(nameof(Age));
                OnPropertyChanged(nameof(ZodiacChinese));
                OnPropertyChanged(nameof(ZodiacWest));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
    

