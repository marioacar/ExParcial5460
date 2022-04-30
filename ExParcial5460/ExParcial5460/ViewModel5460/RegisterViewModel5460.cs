using ExParcial5460.Model5460;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Xamarin.Forms;


namespace ExParcial5460.ViewModel5460
{
    public class RegisterViewModel5460 : BaseViewModel5460
    {
        private string Name;
        private string FLastName;
        private string MLastName;
        private string phone;


        

        public string NameText
        {
            get { return this.Name; }
            set { SetValue(ref this.Name, value); }
        }

        private void SetValue(ref string name, string value)
        {
            throw new NotImplementedException();
        }

        public string FLastNameText
        {
            get { return this.FLastName; }
            set { SetValue(ref this.FLastName, value); }
        }

        public string MLastNameText
        {
            get { return this.MLastName; }
            set { SetValue(ref this.MLastName, value); }
        }

        private string PhoneNumber
        {
            get { return this.phone; }
            set { SetValue(ref this.phone, value); }
        }


        public ICommand cmdINameValidation
        {
            get { return new RelayCommand(NameTextValidations); }
            set { }
        }
        public ICommand cmdIFLastNameValidation
        {
            get { return new RelayCommand(FLastNameValidations); }
            set { }
        }
        public ICommand cmdIMLastNameValidation
        {
            get { return new RelayCommand(MLastNameValidations); }
            set { }
        }
        public ICommand cmdIPhone
        {
            get { return new RelayCommand(PhoneValidation); }
            set { }
        }
        public ICommand cmdIBtnRegister
        {
            get { return new RelayCommand(BtnValidation); }
            set { }
        }


        private void NameTextValidations()
        {
            if (NameText != null)
            {
                string lastCharacter = NameText[NameText.Length - 1].ToString();
                if (!Regex.IsMatch(lastCharacter, @"^[a-zA-Z]+$"))
                {
                    NameText = NameText.Substring(0, NameText.Length - 1);
                }
            }
        }

        private void FLastNameValidations()
        {
            if (FLastName != null)
            {
                string lastCharacter = FLastName[FLastName.Length - 1].ToString(); ;
                if (!Regex.IsMatch(lastCharacter, @"^[a-zA-Z]+$"))
                {
                    FLastName = FLastName.Substring(0, FLastName.Length - 1);
                }
            }
        }

        private void MLastNameValidations()
        {
            if (MLastName != null)
            {
                string lastCharacter = MLastName[FLastName.Length - 1].ToString(); ;
                if (!Regex.IsMatch(lastCharacter, @"^[a-zA-Z]+$"))
                {
                    MLastName = MLastName.Substring(0, MLastName.Length - 1);
                }
            }
        }

        private void PhoneValidation()
        {
            if (PhoneNumber.Length > 0)
            {
                if (PhoneNumber.Length <= 10)
                {
                    String lastCharacter = PhoneNumber[PhoneNumber.Length - 1].ToString();
                    if (!Regex.IsMatch(lastCharacter, @"^[0-9]*$"))
                    {
                        PhoneNumber = PhoneNumber.Substring(0, PhoneNumber.Length - 1);
                    }
                }
                else
                {
                    PhoneNumber = PhoneNumber.Substring(0, 10);
                }
            }
        }

        async private void BtnValidation()
        {
            if (NameText?.Length > 0 && FLastName?.Length > 0 && MLastName?.Length > 0)
            {
                User5460 user = new User5460()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = NameText,
                    FLastName = FLastName,
                    MLastName = MLastName,
                    Phone = PhoneNumber,
                };
                //await Application.Current.MainPage.DisplayAlert("Gracias por registrarse");
                Application.Current.MainPage = new NavigationPage(new View5460.Principal5460(user));
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Favor de llenar el formulario", "Informacion Incorrecta", "Ok");
            }
        }
    }
}
