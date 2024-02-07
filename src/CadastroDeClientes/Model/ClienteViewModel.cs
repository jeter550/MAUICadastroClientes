using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CustomerModel: ViewModelBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(() => Name); }
        }

        private string _lastname;

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; OnPropertyChanged(() => Lastname); }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { 
                _age = value; 
                OnPropertyChanged(() => Age); }
        }

        private string _adress;
        public string Adress
        {
            get { return _adress; }
            set { _adress = value; OnPropertyChanged(() => Adress); }
        }
    }
}
