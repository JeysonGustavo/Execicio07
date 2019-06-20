using AppUserProfile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppUserProfile.ViewModels
{
    public class UserProfileViewModel
    {
        private List<string> _menuOption;
        public List<string> MenuOption
        {
            get { return _menuOption; }
            private set
            {
                if (_menuOption == value)
                    return;

                _menuOption = value;
            }
        }

        public UserProfileViewModel()
        {
            this.MenuOption = GetMenuOptions();
        }

        public List<string> GetMenuOptions()
        {
            return new List<string>
            {
                "Miguel de Icaza",
                "Joseph Hill",
                "Nat Friedman",
                "Sobre Xamarin"
            };
        }

    }
}
