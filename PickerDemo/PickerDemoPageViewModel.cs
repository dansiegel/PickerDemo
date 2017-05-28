using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PickerDemo
{
    public class PickerDemoPageViewModel : INotifyPropertyChanged
    {
        public PickerDemoPageViewModel()
        {
            SomeDate = DateTime.Now.AddDays(-7);
            SomeCollection = new ObservableCollection<string>
            {
                "Randolph Carroll",
                "Orlando Terry",
                "Gwen Wilson",
                "Muriel Nguyen",
                "Gwendolyn Swanson",
                "Pat Mcdaniel",
                "Lynn Herrera",
                "Irene Clark",
                "Leigh Phillips",
                "George Maxwell"
            };
        }

        public string SelectedItem { get; set; }

        public string AnotherItem { get; set; }

        public DateTime SomeDate { get; set; }

        public ObservableCollection<string> SomeCollection { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
