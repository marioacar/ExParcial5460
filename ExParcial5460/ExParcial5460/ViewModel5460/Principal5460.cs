using ExParcial5460.Model5460;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExParcial5460.ViewModel5460
{
    public class Principal5460 : BaseViewModel6796
    {
        private User5460 user;

        public User5460 User
        {
            get { return this.User; }
            set { this.User = value; OnPropertyChanged(); }
        }

        
    }
}
