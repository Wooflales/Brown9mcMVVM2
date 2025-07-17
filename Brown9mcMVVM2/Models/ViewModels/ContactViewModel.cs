using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Brown9mcMVVM2.Models.ViewModels;

partial class ContactViewModel : INotifyPropertyChanged
{
    private string contactName;
    public string ContactName
    {
        get { return contactName; }
        set
        {
            contactName = value;
            NotifyPropertyChanged(nameof(ContactName));
        }
    }
    public string contactEmail { get; set; }
    public string contactPhoneNumber { get; set; }
    public string contactDescription { get; set; }
    public event PropertyChangedEventHandler? PropertyChanged;
    private void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
