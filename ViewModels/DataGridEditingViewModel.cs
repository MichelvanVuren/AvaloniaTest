using Avalonia.Controls;
using AvaloniaTest.Models;
using AvaloniaTest.Services;
using DynamicData;
using DynamicData.Binding;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;

namespace AvaloniaTest.ViewModels
{
    public class DataGridEditingViewModel : ViewModelBase
    {
        private Country _selectedCountry;
        public Country SelectedCountry
        {
            get => _selectedCountry;
            private set => this.RaiseAndSetIfChanged(ref _selectedCountry, value);
        }

        private string? _input;
        public string? Input 
        { 
            get => _input;
            private set => this.RaiseAndSetIfChanged(ref _input, value);
        }

        private SourceCache<Country, int> _countryCache = new SourceCache<Country, int>(x => x.CountryId);
        public ReadOnlyObservableCollection<Country> Countries => _countries;
        private readonly ReadOnlyObservableCollection<Country> _countries;

        private readonly IDisposable _countryCleanUp;

        public ReactiveCommand<System.Reactive.Unit, System.Reactive.Unit> AddCountryCommand { get; }
        public ReactiveCommand<System.Reactive.Unit, System.Reactive.Unit> DeleteCountryCommand { get; }
        public ReactiveCommand<System.Reactive.Unit, System.Reactive.Unit> EditCountryCommand { get; }

        public DataGridEditingViewModel(IEnumerable<Country> countries)
        {
            _countryCache.AddOrUpdate(countries);

            _countryCleanUp = _countryCache.Connect()
                .Sort(SortExpressionComparer<Country>
                    .Ascending(c => c.Name))
                .Bind(out _countries)
                .DisposeMany()
                .Subscribe();

            this.WhenAnyValue(x => x.SelectedCountry)
                .Subscribe(x => Input = x?.Name);

            AddCountryCommand = ReactiveCommand.Create(() =>
            {
                if (Input != null)
                {
                    var newCountry = new Country
                    {
                        Name = Input
                    };
                    _countryCache.AddOrUpdate(newCountry);
                    Input = null;
                }
            });

            DeleteCountryCommand = ReactiveCommand.Create(() =>
            {
                if (SelectedCountry != null)
                {
                    _countryCache.Remove(SelectedCountry);
                }
            });

            EditCountryCommand = ReactiveCommand.Create(() =>
            {
                if (SelectedCountry != null && Input != null)
                {
                    var editedSelectedCountry = new Country() { CountryId = SelectedCountry.CountryId, Name = Input };
                    _countryCache.AddOrUpdate(editedSelectedCountry);
                    Input = null;
                }
            });
        }

        public void Dispose()
        {
            _countryCleanUp.Dispose();
        }
    }
}
