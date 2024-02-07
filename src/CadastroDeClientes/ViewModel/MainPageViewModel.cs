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
                new CustomerModel() {  Name = "João", Lastname = "Santos", Age = 41, Adress = "Rua 1, Jd Das Flores" },
                new CustomerModel() {  Name = "Maria", Lastname = "Ferreira", Age = 27, Adress = "Av Jardineiro, Tela dois" },
                new CustomerModel() {  Name = "José", Lastname = "Aldo", Age = 19, Adress = "Rua dos Lanranjais, Parque Um" },
                new CustomerModel() {  Name = "Anderson", Lastname = "Mariano", Age = 18, Adress = "Travessa Cinco, Vila das Alves" },
                new CustomerModel() {  Name = "Richard", Lastname = "Torres", Age = 40, Adress = "Quarta com Sexta, Novos Ares" },
            };

            this.SelectedCustomer = new CustomerModel();

            this.ItemSelectedCommand = new Command(OnItemSelectedCommand);

            this.AddCommand = new Command(OnAddCommand);
            this.DeleteCommand = new Command(OnDeleteCommand);
            this.EditCommand = new Command(OnEditCommand);
        }

        private void OnEditCommand(object sender)
        {

            this.SelectedCustomer = (CustomerModel)sender;
        }

        private void OnAddCommand(object sender)
        {
            var newItem = new CustomerModel();
            this.CustomersList.Add(newItem);
            this.SelectedCustomer = newItem;

        }

        private async void OnDeleteCommand(object sender)
        {
            if (this.CustomersList.Count > 0)
            {
                if(await this.PageContainer.DisplayAlert("Confirmar exclusão", "Tem certeza que deseja excluir o cliente selecionado?", "Sim", "Não"))
                    this.CustomersList.Remove((CustomerModel)sender);
            }

        }

        private void OnItemSelectedCommand(object obj)
        {
        }

        private CustomerModel _clienteSelecionado;
        public CustomerModel SelectedCustomer
        {
            get { return _clienteSelecionado; }
            set { _clienteSelecionado = value; OnPropertyChanged(() => SelectedCustomer); }
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
        
        private ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                return _addCommand;
            }
            set
            {
                _addCommand = value;
                OnPropertyChanged(() => AddCommand);
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

        private ICommand _editCommand;
        public ICommand EditCommand
        {
            get
            {
                return _editCommand;
            }
            set
            {
                _editCommand = value;
                OnPropertyChanged(() => EditCommand);
            }
        }


    }
}
