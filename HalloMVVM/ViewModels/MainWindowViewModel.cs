using System;
using System.Windows.Input;

namespace HalloMVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        // In ViewModels ObservableCollection<T> statt List<T>

        private string _welcomeText = "<10Zeic";
        public string WelcomeText
        {
            get { return _welcomeText; }
            set
            {
                _welcomeText = value;
                RaisePropertyChanged();
            }
        }

        private ICommand _changeTextCommand;
        public ICommand ChangeTextCommand
        {
            get
            {
                return _changeTextCommand ?? (_changeTextCommand = new RelayCommand(
                    () => WelcomeText = "Hallo nochmal aus dem VM. :D",
                    () => WelcomeText.Length < 10));
            }
        }

        //public MainWindowViewModel()
        //{
        //    ChangeTextCommand = new RelayCommand(Machwas, Gehts);
        //}

        //private bool Gehts()
        //{
        //    return WelcomeText.Length < 10;
        //}

        //public void MachWas()
        //{
        //    WelcomeText = "Hallo nochmal aus dem VM. :D";
        //}
    }
}
