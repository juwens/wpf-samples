using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace listbox_grouping
{
    public class MainViewModel
    {
        public ObservableCollection<Planet> Planets { get; } = new ObservableCollection<Planet>();

        public MainViewModel()
        {
            new List<Planet>()
            {
                new Planet{Name="Mercury", IsInner=true},
                new Planet{Name="Venus", IsInner=true},
                new Planet{Name="Earth", IsInner=true},
                new Planet{Name="Mars", IsInner=true},
                new Planet{Name="Jupiter",IsInner=false},
                new Planet{Name="Satur", IsInner= false},
                new Planet{Name="Uranus", IsInner=false},
                new Planet{Name="Neptune", IsInner=false},
            }.ForEach(Planets.Add);
        }
    }
}
