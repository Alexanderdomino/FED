using System;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TheDeptBook.MVVM.ViewModel
{
    public partial class ContactWindowViewModel : MVVM.ViewModel.MainViewModel
    {
        
        [RelayCommand]
        void CloseAddContact()
        {
            //implement close
        }

        [RelayCommand]
        void Add()
        {
            Trace.WriteLine("trying to add contact");
            Contacts.Add(new Contact("3", "Muddi fra bæst", 200));
            Trace.WriteLine("should have been added here");
        }
    }
}