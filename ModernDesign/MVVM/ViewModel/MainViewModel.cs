using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace ModernDesign.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public RelayCommand InventoryViewCommand { get; set; }

        public RelayCommand TimeLineViewCommand { get; set; }

        public RelayCommand BudgetViewCommand { get; set; }

        public RelayCommand DashBoardViewCommand { get; set; }
        public HomeViewModel HomeVm { get; set; }

        public DiscoveryViewModel DiscoveryVm { get; set; }

        public InventoryViewModel InventoryVm { get; set; }

        public TimeLineViewModel TimeLineVm { get; set; }

        public BudgetViewModel BudgetVm { get; set; }

        public DashBoardViewModel DashBoardVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            {   _currentView = value;
                OnPropertyChanged();            
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            DiscoveryVm = new DiscoveryViewModel();
            InventoryVm = new InventoryViewModel();
            TimeLineVm = new TimeLineViewModel();
            BudgetVm = new BudgetViewModel();
            DashBoardVm = new DashBoardViewModel();
            CurrentView = DashBoardVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = DashBoardVm;
            });
            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVm;
            });
            InventoryViewCommand = new RelayCommand(o =>
            {
                CurrentView = InventoryVm;
            });
            TimeLineViewCommand = new RelayCommand(o =>
            {
                CurrentView = TimeLineVm;
            });
            BudgetViewCommand = new RelayCommand(o =>
            {
                CurrentView = BudgetVm;
            });
            DashBoardViewCommand = new RelayCommand(o =>
            {
                CurrentView = DashBoardVm;
            });
        }
    }
}
