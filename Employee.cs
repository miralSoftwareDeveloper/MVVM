using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        
        private string name;
        
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please enter name.")]
        [StringLength(10, ErrorMessage = "Maximum 10 Character")]
        [MinLength(5, ErrorMessage ="Minimum 5 Character")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                ValidateProperty(value,nameof(Name));
                OnPropertyChanged(nameof(Name));
            }
        }


        private string address;

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        private string city;

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                OnPropertyChanged(nameof(City));
            }
        }


        private string state;

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
                OnPropertyChanged(nameof(State));
            }
        }


        private void ValidateProperty<T>(T value, string propertyName)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = propertyName,
            }
            ) ;
        }



    }
}
