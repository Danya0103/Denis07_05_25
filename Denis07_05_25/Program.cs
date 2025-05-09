using System;

class Program {

    static void Main(string[] args) {

        Console.WriteLine(RomanToInteger("M"));

    }

    static int RomanToInteger(string number) {

        switch (number) {

            case "I":
                return 1;
            case "V":
                return 5;
            case "X":
                return 10;
            case "L":
                return 50;
            case "C":
                return 100;
            case "D":
                return 500;
            case "M":
                return 1000;
            default:
                return 0;

        }
    }
}
