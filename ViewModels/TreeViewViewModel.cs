using AvaloniaTest.Models;
using DynamicData;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace AvaloniaTest.ViewModels
{
    public class TreeViewViewModel : ViewModelBase
    {
        public ObservableCollection<Country> Countries { get; }

        public TreeViewViewModel(ObservableCollection<Country> countries)
        {
            Countries = countries;
        }
    }
}
