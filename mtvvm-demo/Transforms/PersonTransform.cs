using mtvvm_demo.Services;
using mtvvm_demo.ViewModels;

namespace mtvvm_demo.Transforms
{
    public class PersonTransform : IPersonTransform
    {
        private readonly IAddressService addressService;

        public PersonTransform(IAddressService addressService)
        {
            // I passed in an IAddressService to illustrate how you can use Dependency Injection here
            this.addressService = addressService;
        }

        public PersonViewModel GetPerson()
        {
            // call into our outside address service
            var address = addressService.GetAddress();                            

            // populate the PersonViewModel from different services and maintain a 'flat' object
            var personViewModel = new PersonViewModel
            {
                Name = "Person 1",
                Age = 1,
                Street = address.Street,
                ZipCode = address.ZipCode
            };

            return personViewModel;
        }
    }
}