using Checkout.Types;

namespace Checkout.Interfaces
{
    public interface IScanned
    {
        Product GetLastScanned();
    }
}
