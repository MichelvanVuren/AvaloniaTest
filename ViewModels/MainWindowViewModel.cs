using AvaloniaTest.Services;
using ReactiveUI;

namespace AvaloniaTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            ComboBoxFilterViewModel = new ComboBoxFilterViewModel(Database.GetCountries(), Database.GetCities());
            DataGridEditingViewModel = new DataGridEditingViewModel(Database.GetCountries());
        }

        public ComboBoxFilterViewModel ComboBoxFilterViewModel { get; }

        public DataGridEditingViewModel DataGridEditingViewModel { get; }
    }
}
