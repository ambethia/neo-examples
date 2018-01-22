using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class StorageGet : Framework.SmartContract
    {
        public static object Main()
        {
            return Storage.Get(Storage.CurrentContext, "Fizz");
        }
    }
}
