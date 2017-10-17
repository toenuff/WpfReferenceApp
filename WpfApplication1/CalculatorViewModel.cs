using Prism.Commands;
using System.ComponentModel;
using System.Windows.Input;

namespace WpfApplication1
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public CalculatorViewModel()
        {
            _calculateCommand = new DelegateCommand(() =>
            {
                Calculator calc = new Calculator();
                this.Result = calc.Calculate(this.input);
            });
        }
        ICommand _calculateCommand;
        int _result;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CalculateCommand {
            get
            {
                return _calculateCommand;
            }
        }
        public string input { get; set; }
        public int Result {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new  PropertyChangedEventArgs("Result"));
                }
            }
        }
    }
}