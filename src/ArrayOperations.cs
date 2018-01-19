using Neo.SmartContract.Framework.Services.Neo;
using System;

namespace Neo.SmartContract
{
    public class ArrayOperations : Framework.SmartContract
    {
        public static int Main(int a)
        {
            int[] arr = new int[2];
            arr[0] = a;
            arr[1] = a * 2;
            return arr.Length;
        }
    }
}

