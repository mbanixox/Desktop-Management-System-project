using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginForm.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private string _computerName;
        private string _ipAddress;

        public string ComputerName
        {
            get
            {
                return _computerName;
            }
            set
            {
                _computerName = value;
                OnPropertyChanged(nameof(ComputerName));
            }
        }

        public string IpAddress
        {
            get
            {
                return _ipAddress;
            }
            set
            {
            _ipAddress = value;
            OnPropertyChanged(nameof(IpAddress));
            }
        }

        public HomeViewModel()
        {
            // Local machine name
            ComputerName = Environment.MachineName.ToString();

            // local machine IP
            IpAddress = Dns.GetHostEntry(Dns.GetHostName())
                       .AddressList
                       .First(x => x.AddressFamily == AddressFamily.InterNetwork)
                       .ToString();

        }

    }
}
