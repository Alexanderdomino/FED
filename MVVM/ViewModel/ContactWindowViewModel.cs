using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TheDeptBook
{
    public partial class ContactWindowViewModel : ObservableObject
    {


        [RelayCommand]
        void CloseAddContact()
        {
            //Implement logic
        }

        [RelayCommand]
        void Add()
        {
        }
    }
}
