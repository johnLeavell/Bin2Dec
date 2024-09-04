using System;

class Bin2Dec
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Enter a binary number (up to 8 digits): ");
            string binaryInput = Console.ReadLine();

            // Check if the input is valid (only contains '0' and '1' and is up to 8 digits long)
            if (!IsValidBinary(binaryInput))
            {
                Console.WriteLine("Invalid input. Please enter only binary digits (0 or 1) up to 8 digits.\n");
                continue; // Continue the loop if the input is invalid
            }

            // Convert binary to decimal
            int decimalValue = ConvertBinaryToDecimal(binaryInput);
            Console.WriteLine($"The decimal equivalent of {binaryInput} is: {decimalValue}\n");

            break; // Exit the loop after a valid input is processed
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(); // Wait for the user to press a key before closing
    }

    // Method to validate if the input string is a binary number
    static bool IsValidBinary(string input)
    {
        if (input.Length == 0 || input.Length > 8)
            return false;

        foreach (char c in input)
        {
            if (c != '0' && c != '1')
                return false;
        }

        return true;
    }

    // Method to convert binary string to decimal using mathematical functions
    static int ConvertBinaryToDecimal(string binary)
    {
        int decimalValue = 0;
        int length = binary.Length;

        for (int i = 0; i < length; i++)
        {
            // Convert each binary digit to decimal using the power function
            if (binary[i] == '1')
            {
                decimalValue += (int)Math.Pow(2, length - i - 1);
            }
        }

        return decimalValue;
    }
}
