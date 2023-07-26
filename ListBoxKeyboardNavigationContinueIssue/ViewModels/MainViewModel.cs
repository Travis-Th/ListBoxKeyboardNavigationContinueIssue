using System.Collections.ObjectModel;
using System.Linq;

namespace ListBoxKeyboardNavigationContinueIssue.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public ObservableCollection<int> TestData { get; } = new(Enumerable.Range(1, 100));
}
