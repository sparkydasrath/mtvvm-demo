using System.Threading;
using mtvvm_demo.ViewModels;

namespace mtvvm_demo.Transforms
{
    public interface IPersonTransform
    {
        PersonViewModel GetPerson();
    }
}