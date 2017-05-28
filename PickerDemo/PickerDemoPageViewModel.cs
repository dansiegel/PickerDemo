using System;
using System.ComponentModel;

namespace PickerDemo
{
    public class PickerDemoPageViewModel : INotifyPropertyChanged
    {
        public PickerDemoPageViewModel()
        {
        }

        public string SelectedItem { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
