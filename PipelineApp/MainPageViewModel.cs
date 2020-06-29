using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PipelineApp
{
    public class MainPageViewModel : BindableObject
    {
        private string _buttonText;
        private string _entryText;

        public ICommand ButtonClickedCommand { get; private set; }

        public MainPageViewModel(string buttonText)
        {
            ButtonText = buttonText;
            ButtonClickedCommand = new Command(HandleButtonClicked);
            EntryText = "Enter some text to change the button";

        }

        private void HandleButtonClicked()
        {
            ButtonText = EntryText;
        }

        public string EntryText
        {
            get => _entryText;
            set
            {
                if (value == _entryText) return;
                _entryText = value;
                OnPropertyChanged();
            }
        }

        public string ButtonText
        {
            get => _buttonText;
            set
            {
                if (value == _buttonText) return;
                _buttonText = value;
                OnPropertyChanged();
            }
        }
    }
}
