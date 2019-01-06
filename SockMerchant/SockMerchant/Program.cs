using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {

        int pairsFound = 0;
        var sockColorHash = new Dictionary<int, int>();

        foreach (var sock in ar)
        {
            if (sockColorHash.ContainsKey(sock))
            {
                pairsFound++;
                sockColorHash.Remove(sock);
            }
            else
                sockColorHash.Add(sock, 1);
        }
        return pairsFound;




    }

    static void Main(string[] args)
    {
        

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Console.ReadLine().Trim().Split(' ').Select(x => Int32.Parse(x)).ToArray();
        int result = sockMerchant(n, ar);

       
    }
}
