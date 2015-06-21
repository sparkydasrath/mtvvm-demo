using System.Windows;
using mtvvm_demo.Services;
using mtvvm_demo.Transforms;
using mtvvm_demo.ViewModels;

namespace mtvvm_demo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // these should all be injected via Dependency Injection container
            var addressService = new AddressService();
            var personTransform = new PersonTransform(addressService);               
            DataContext = new PeopleViewModel(personTransform);
        }
    }
}
