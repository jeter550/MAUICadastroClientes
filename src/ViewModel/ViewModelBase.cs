using System.ComponentModel;
using System.Linq.Expressions;

namespace ViewModel
{
    // All the code in this file is included in all platforms.
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged<T>(Expression<Func<T>> expressao)
        {
            string name = ((MemberExpression)expressao.Body).Member.Name;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private Page _pageContainer;
        public Page PageContainer
        {
            get
            {
                return _pageContainer;
            }
            set
            {
                _pageContainer = value;
                OnPropertyChanged(() => PageContainer);
            }
        }
    }
}
