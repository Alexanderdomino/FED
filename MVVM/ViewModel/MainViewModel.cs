using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TheDeptBook.MVVM.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel() {
            Contacts.Add(new Contact("0", "Nina", 120000));
            Contacts.Add(new Contact("1", "Bob", 130000));
            CurrentContact = Contacts[0];
        }

        //------------Commands------------//
        [RelayCommand]
        void OpenAddContact()
        {
            Trace.WriteLine("Opening contactwindow");
            ContactWindow objContactWindow = new();
            objContactWindow.Show();
            Contacts.Add(new Contact("3", "Muddi", 6000));

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
