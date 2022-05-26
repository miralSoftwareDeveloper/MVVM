using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Windows;
using System.Collections.ObjectModel;
using System.Collections;

namespace MVVM
{
    class VMEmployees : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        #region Events
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(propertyName)));

        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            OnPropertyChanged(nameof(CanCreate));

        }
        #endregion
        #region Properties
        Dictionary<string, List<string>> DataErrors = new Dictionary<string, List<string>>();

        private string _employeeName;

        public string EmployeeName
        {
            get { return _employeeName; }
            set
            {
                _employeeName = value;
                ClearErrors(nameof(EmployeeName));
                if (_employeeName.Length < 5)
                {
                    AddError(nameof(EmployeeName), "Please enter the name");
                    AddError(nameof(EmployeeName), "Please enter the name");
                }
                OnPropertyChanged(nameof(EmployeeName));

            }
        }

        private string _employeeAddress;

        public string EmployeeAddess
        {
            get
            {
                return _employeeAddress;
            }
            set
            {
                _employeeAddress = value;
                OnPropertyChanged(nameof(EmployeeAddess));
            }
        }

        private string _employeeCity;

        public string EmployeeCity
        {
            get
            {
                return _employeeCity;
            }
            set
            {
                _employeeCity = value;
                OnPropertyChanged(nameof(EmployeeCity));
            }
        }

        private string _employeeState;

        public string EmployeeState
        {
            get
            {
                return _employeeState;
            }
            set
            {
                _employeeState = value;
                OnPropertyChanged(nameof(EmployeeState));
            }
        }

        private static ObservableCollection<Employee> listemployees { get; set; }

        public ObservableCollection<Employee> Listemployees
        {
            get { return listemployees; }
            set
            {
                listemployees = value;
                OnPropertyChanged(nameof(listemployees));


            }
        }


        #endregion

        public VMEmployees()
        {
            listemployees = new ObservableCollection<Employee>()
            {
                new Employee(){ Name="Miral",Address="Vasna",City="Vadodara",State="Gujarat"},
                new Employee(){ Name="Davee",Address ="Brampton",City="Toronto",State ="Ontario"},
                new Employee(){ Name="Chetana",Address="Adajan",City ="Surat",State ="Gujarat"}

            };


        }



        #region Commands
        private ICommand mAdd;
        public ICommand AddCommand
        {
            get
            {
                if (mAdd == null)
                    mAdd = new Add();
                return mAdd;
            }
            set
            {
                mAdd = value;
            }
        }
        private class Add : ICommand
        {

            public event EventHandler CanExecuteChanged;
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                VMEmployees employee = (VMEmployees)parameter;
                
                Employee emp = new Employee();
                emp.Name = employee.EmployeeName;
                emp.State = employee.EmployeeState;
                emp.Address = employee.EmployeeAddess;
                emp.City = employee.EmployeeCity;

                employee.Listemployees.Add(emp);
                


            }


        }

        public bool CanCreate => !HasErrors;
        public static void AddEmployee(Employee employee)
        {

            listemployees.Add(employee);
        }

        #endregion

        #region Validation
        public bool HasErrors => DataErrors.Any();
        public IEnumerable? GetErrors(string? propertyName)
        {
            if (propertyName == null)
            {
                return null;
            }
            else
            {
                return DataErrors.GetValueOrDefault(propertyName);

            }
        }
        private void AddError(string propertyName, string error)
        {
            if (!DataErrors.ContainsKey(propertyName))
            {
                DataErrors.Add(propertyName, new List<string>());
            }
            DataErrors[propertyName].Add(error);
            OnErrorsChanged(propertyName);
        }

        private void ClearErrors(string propertyName)
        {

            if (DataErrors.Remove(propertyName))
                OnErrorsChanged(propertyName);

        }

        #endregion



    }
}
