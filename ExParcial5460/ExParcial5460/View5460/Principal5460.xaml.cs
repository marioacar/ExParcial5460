using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExParcial5460.View5460
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal5460 : ContentPage
    {
        public Principal5460(Model5460.User5460 user)
        {
            InitializeComponent();
        }
    }
}