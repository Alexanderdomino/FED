using System.Runtime.Serialization;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TheDeptBook
{
    public partial class ContactWindowViewModel : MainViewModel
    {
        public ContactWindowViewModel()
        {
            
        }


        [RelayCommand]
        void CloseAddContact()
        {
            ObjContactWindow.Hide();
        }

        [RelayCommand]
        void Add()
        {
            Contacts.Add(new Contact("3","Muddi",-200));
        }
    }
}
