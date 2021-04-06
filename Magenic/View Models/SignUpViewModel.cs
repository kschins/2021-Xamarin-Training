using System.ComponentModel;
using Xamarin.Forms;

namespace Magenic
{
    public class SignUpViewModel: INotifyPropertyChanged
    {
        private string email;
        private string firstName;
        private string lastName;
        private string phone;
        private string password;
        private bool agreedToTerms;

        public event PropertyChangedEventHandler PropertyChanged;
        public Command SignUpCommand { get; }
        public INavigation Navigation { get; set; }

        public string Email
        {
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged("Email");
                    SignUpCommand.ChangeCanExecute();
                }
            }
            get => email;
        }

        public string FirstName
        {
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged("FirstName");
                    SignUpCommand.ChangeCanExecute();
                }
            }
            get => firstName;
        }

        public string LastName
        {
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged("LastName");
                    SignUpCommand.ChangeCanExecute();
                }
            }
            get => lastName;
        }

        public string Phone
        {
            set
            {
                if (phone != value)
                {
                    phone = value;
                    OnPropertyChanged("Phone");
                    SignUpCommand.ChangeCanExecute();
                }
            }
            get => phone;
        }
        
        public string Password
        {
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged("Password");
                    SignUpCommand.ChangeCanExecute();
                }
            }
            get => password;
        }

        public bool AgreedToTerms
        {
            set
            {
                if (agreedToTerms != value)
                {
                    agreedToTerms = value;
                    OnPropertyChanged("AgreedToTerms");
                    SignUpCommand.ChangeCanExecute();
                }
            }
            get => agreedToTerms;
        }

        public SignUpViewModel()
        {
            SignUpCommand = new Command(OnSignUpButtonClicked, SignUpAllowed);
        }

        public SignUpViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SignUpCommand = new Command(OnSignUpButtonClicked, SignUpAllowed);
        }

        public bool SignUpAllowed(object sender)
        {
            return !string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(firstName) &&
                !string.IsNullOrEmpty(lastName) &&
                !string.IsNullOrEmpty(phone) &&
                !string.IsNullOrEmpty(password) &&
                agreedToTerms;
        }

        private void OnSignUpButtonClicked(object sender)
        {
            // this should probably do something -- need to figure out best practices
            // for triggering navigation from the view model?
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
