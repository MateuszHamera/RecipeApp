using RecipeApp.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecipeApp.ViewModel
{
    class AddProductViewModel : INotifyPropertyChanged
    {

        public AddProductViewModel()
        {
            AddProductCommand = new DelegateCommand(AddProduct);
        }

        public ICommand AddProductCommand;

        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddProduct()
        {

        }
    }
}
