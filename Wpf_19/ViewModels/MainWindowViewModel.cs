using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_19.Models;

namespace Wpf_19.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private double radius;
        private double circumference;
        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }



        public double Circumference
        {
            get => circumference;
            set
            {
                circumference = value;
                OnPropertyChanged();
            }
        }


        public ICommand AddCommand { get; }

        private void OnAddCommandExecute(object p)
        {
            Circumference = LengthCircle.Add(Radius);
        }
        private bool CanAddCommandExecuted(object p)
        {

            return
                true;

        }
        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);

        }
    }
}
