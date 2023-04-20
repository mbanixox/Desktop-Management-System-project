using System.Windows.Input;


namespace WPF_LoginForm.ViewModels
{
    public class AddCompViewModel : ViewModelBase
    {
        private string _rdpUsername;
        private string _rdpPassword;
        private string _clientIP;

        
        
        
        public string RdpUsername
        {
            get { return _rdpUsername; }
            set
            {
                _rdpUsername = value;
                OnPropertyChanged(nameof(RdpUsername));
            }
        }

        
        public string RdpPassword
        {
            get { return _rdpPassword; }
            set
            {
                _rdpPassword = value;
                OnPropertyChanged(nameof(RdpPassword));
            }
        }

        public string ClientIP
        { 
            get 
            { 
                return _clientIP; 
            }
            set
            {
                _clientIP = value;
                OnPropertyChanged(nameof(ClientIP));
            }
        }

        // Commands
        public ICommand ConnectCommand { get; set; }
        public ICommand DisconnectCommand { get; set; }

        // Constructor
        public AddCompViewModel()
        {
           // ConnectCommand = new ViewModelCommand(Connect);
           // DisconnectCommand = new ViewModelCommand(Disconnect);
            

        }

        private void Connect()
        {
            /*
        
            var rdpClient = new axMsRdpClient6NotSafeForScripting1();

            // Set the necessary properties for the RDP client object
            rdpClient.Server = ClientIP;
            rdpClient.UserName = RdpUsername;
            rdpClient.AdvancedSettings2.ClearTextPassword = RdpPassword;
            rdpClient.AdvancedSettings7.EnableCredSspSupport = true;

            rdpClient.Connect();

            */

        }
        private void Disconnect()
        {
            /*
            if (axMsRdpClient6NotSafeForScripting1.Connected.ToString() == "1")
                axMsRdpClient6NotSafeForScripting1.Disconnect();
            */
        }



    }
}
