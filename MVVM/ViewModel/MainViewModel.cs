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
            Contacts.Add(new Contact("0", "Nina", 120000));
            Contacts.Add(new Contact("1", "Bob", 130000));
            CurrentContact = contacts[0];
            
        }

        //------------Commands------------//
        [RelayCommand]
        void OpenAddContact()
        {
            ObjContactWindow.Show();
        }

        //-----------Properties-----------//

        [ObservableProperty]
        ObservableCollection<Contact> contacts = new();
        
        [ObservableProperty]
        ContactWindow objContactWindow = new();

        [ObservableProperty]
        Contact? currentContact = null;

        [ObservableProperty]
        private int currentIndex;
    }


}
