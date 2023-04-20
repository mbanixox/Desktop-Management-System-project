using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_LoginForm.Models;
using WPF_LoginForm.Repositories;

namespace WPF_LoginForm.ViewModels
{
    public class UsersViewModel : ViewModelBase
    {
        public class UserViewModel
        {
            public ObservableCollection<UserModel> Users { get; set; }

            public UserViewModel()
            {
                var userRepository = new UserRepository();
                Users = new ObservableCollection<UserModel>(userRepository.GetByAll());
            }
        }

    }
}
