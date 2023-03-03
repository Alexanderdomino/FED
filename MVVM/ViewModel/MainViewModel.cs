using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDeptBook
{
    public partial class MainViewModel : ObservableObject
    {

        public MainViewModel() {
            contacts.Add(new Contact("0", "Nina", 120000));
            contacts.Add(new Contact("1", "Bob", 130000));
            CurrentContact = contacts[0];
        }

        //------------Commands------------//
        [RelayCommand]
        void OpenAddContact()
        {
            ContactWindow objContactWindow = new();
            objContactWindow.Show();
        }

        //-----------Properties-----------//

        [ObservableProperty]
        ObservableCollection<Contact> contacts = new();

        [ObservableProperty]
        Contact? currentContact = null;

        [ObservableProperty]
        private int currentIndex;
    }


}
