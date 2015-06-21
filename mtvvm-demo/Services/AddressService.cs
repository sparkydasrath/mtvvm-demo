using mtvvm_demo.Models;

namespace mtvvm_demo.Services
{
    public class AddressService : IAddressService
    {
        public Address GetAddress()
        {
            // make some call to get the address back
            return new Address {Street = "test street", ZipCode = "test zip code"};
        }
    }
}