using System.Collections.ObjectModel;
using mtvvm_demo.Services;
using mtvvm_demo.Transforms;

namespace mtvvm_demo.ViewModels
{
    public class PeopleViewModel : ViewModelBase
    {
        private ObservableCollection<PersonViewModel> peopleViewModels;

        public PeopleViewModel(IPersonTransform personTransform)
        {
            PeopleViewModels = new ObservableCollection<PersonViewModel>
            {
                // ideally you wouldn't populate the collection at this point, this is just for demo purposes
                personTransform.GetPerson(),
                personTransform.GetPerson()
            };
        }

        public ObservableCollection<PersonViewModel> PeopleViewModels
        {
            get { return peopleViewModels; }
            set
            {
                if (peopleViewModels == value) return;
                peopleViewModels = value;
                RaisePropertyChanged();
            }
        }
    }
}