using System.ComponentModel;

namespace NotifyPropertyChanged.Services
{
    public class AppState : INotifyPropertyChanged
    {
        private string _ChangeableString = "Initial Changeable String";
        public string ChangeableString
        {
            get { return _ChangeableString; }
            set
            {
                if(_ChangeableString != value)
                {
                    _ChangeableString = value;
                    OnPropertyChanged(nameof(ChangeableString));
                }
            }        
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
