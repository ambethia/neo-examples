using Neo.SmartContract.Framework.Services.Neo;

namespace Neo.SmartContract
{
    public class StringConcatenation : Framework.SmartContract
    {
        public static string Main(string name)
        {
            return "Hello, " + name;
        }
    }
}
