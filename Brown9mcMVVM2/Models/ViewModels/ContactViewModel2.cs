using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Brown9mcMVVM2.Models.ViewModels;
partial class ContactViewModel2 : ObservableObject
{
    [ObservableProperty]
    private string contactName;
    [ObservableProperty]
    private string contactEmail;
    [ObservableProperty]
    private string contactPhoneNumber;
    [ObservableProperty]
    private string contactDescription;
}