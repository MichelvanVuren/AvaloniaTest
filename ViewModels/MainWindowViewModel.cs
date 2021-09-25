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
            TreeViewViewModel = new TreeViewViewModel(Database.GetCountryList());
        }

        public ComboBoxFilterViewModel ComboBoxFilterViewModel { get; }

        public DataGridEditingViewModel DataGridEditingViewModel { get; }

        public TreeViewViewModel TreeViewViewModel { get; }
    }
}
