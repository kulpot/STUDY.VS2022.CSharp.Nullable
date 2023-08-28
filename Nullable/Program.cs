using System;

//ref link:https://www.youtube.com/watch?v=id6HpbQ5gek&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=19
//  Dissecting Nullables

class MainClass
{
    static void Main()
    {   // int? -- value range -- int.MinValue, int.MaxValue, int.NullValue
        //Nullable<int> j = null; // int? j = null;
        int? i = 5;
        //object? u = "asfdsdfNULLisValueType"; // error object is reference type must be value type
        //int? j = 6;
        int? j = null;  // 5 + null = null
        int? sum = i + j;
        Console.WriteLine(sum);
    }
}