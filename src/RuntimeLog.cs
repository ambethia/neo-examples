using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class RuntimeLog : Framework.SmartContract
    {
        public static void Main() => Runtime.Log("Hello, World.");
    }
}
