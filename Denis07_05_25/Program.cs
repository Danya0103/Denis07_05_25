using System;
using System.Runtime.InteropServices.Marshalling;

class Program {

    static void Main(string[] args) {

        string seven = "XIX";
        int result = 0;

        for (int i = 0; i < seven.Length; i++)
        {
            result += RomanToInteger(seven[i]);
            
        }
        // 0, 5, 5 + 1 = 6, 6 + 1 = 7.
        Console.WriteLine(result);
    }



    static int RomanToInteger(char number) {

        switch (number) {

            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                return 0;

        }
    }
}
