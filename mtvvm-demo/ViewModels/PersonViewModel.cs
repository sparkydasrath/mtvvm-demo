using System.Windows.Media;

namespace mtvvm_demo.ViewModels
{
    public class PersonViewModel :ViewModelBase
    {
        private string name;
        private int age;
        private string street;
        private string zipCode;

        public string Name
        {
            get { return name; }
            set
            {
                if (name == value) return;
                name = value;
                RaisePropertyChanged();
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (age == value) return;
                age = value;
                RaisePropertyChanged();
            }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set
            {
                if (zipCode == value) return;
                zipCode = value;
                RaisePropertyChanged();
            }
        }

        public string Street
        {
            get { return street; }
            set
            {
                if (street == value) return;
                street = value;
                RaisePropertyChanged();
            }
        }
    }
}