using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModel;

namespace CadastroDeClientes.ViewModel
{
    internal class MainPageViewModel: ViewModelBase
    {
        public MainPageViewModel()
        {
            this.CustomersList = new ObservableCollection<CustomerModel>()
            {
                new CustomerModel() {  Name = "João", Lastname = "Santos", Age = 18, Adress = "Rua 1, Jd Das Flores" },
                new CustomerModel() {  Name = "Maria", Lastname = "Ferreira", Age = 18, Adress = "Av Jardineiro, Tela dois" },
                new CustomerModel() {  Name = "José", Lastname = "Aldo", Age = 18, Adress = "Rua dos Lanranjais, Parque Um" },
                new CustomerModel() {  Name = "Anderson", Lastname = "Mariano", Age = 18, Adress = "Travessa Cinco, Vila das Alves" },
                new CustomerModel() {  Name = "Richard", Lastname = "Torres", Age = 18, Adress = "Quarta com Sexta, Novos Ares" },
            };

            this.ClienteSelecionado = new CustomerModel() { Age = 18 };

            this.ItemSelectedCommand = new Command(OnItemSelectedCommand);

            this.SaveCommand = new Command(OnSaveCommand);
            this.DeleteCommand = new Command(OnSaveCommand);
        }

        private void OnSaveCommand(object obj)
        {
            if (this.CustomersList.Count > 0)
            {
                this.CustomersList.RemoveAt(0);
            }

        }

        private void OnDeleteCommand(object obj)
        {
            if (this.CustomersList.Count > 0)
            {
                this.CustomersList.RemoveAt(0);
            }

        }

        private void OnItemSelectedCommand(object obj)
        {
        }

        private CustomerModel _clienteSelecionado;
        public CustomerModel ClienteSelecionado
        {
            get { return _clienteSelecionado; }
            set { _clienteSelecionado = value; OnPropertyChanged(() => ClienteSelecionado); }
        }

        private ObservableCollection<CustomerModel> _customersList;

        public ObservableCollection<CustomerModel> CustomersList 
        {
            get { return _customersList; }
            set { _customersList = value; OnPropertyChanged(() => CustomersList);  }
        }

        private ICommand _itemSelectedCommand;
        public ICommand ItemSelectedCommand
        {
            get
            {
                return _itemSelectedCommand;
            }
            set
            {
                _itemSelectedCommand = value;
                OnPropertyChanged(() => ItemSelectedCommand);
            }
        }
        
        private ICommand _saveCommand;
        public ICommand SaveCommand
        {
            get
            {
                return _saveCommand;
            }
            set
            {
                _saveCommand = value;
                OnPropertyChanged(() => SaveCommand);
            }
        }

        private ICommand _deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                return _deleteCommand;
            }
            set
            {
                _deleteCommand = value;
                OnPropertyChanged(() => DeleteCommand);
            }
        }

        
    }
}
