using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaTest.Models;

namespace AvaloniaTest.Views
{
    public class ComboBoxFilterView : UserControl
    {
        public ComboBoxFilterView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
