namespace mtvvm_demo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private PersonViewModel peopleViewModel;

        public MainWindowViewModel()
        {
            
        } 


        public PersonViewModel PeopleViewModel
        {
            get { return peopleViewModel; }
            set
            {
                if (peopleViewModel == value) return;
                peopleViewModel = value;
                RaisePropertyChanged();
            }
        }
    }
}