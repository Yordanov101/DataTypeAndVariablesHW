using System;
class BankAccountData
{
    // A bank account has a holder name (first name, middle name and last name),available amount 
    // of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
    // Declare the variables needed to keep the information for a single bank account using the 
    //appropriate data types and descriptive names.
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Ivanov";
        string holderName = firstName + " " + middleName + " " + lastName;
        decimal moneyBalance = 000123.5M;
        string bankName = @"""CorpBank""";
        string uniqueIBAN = "BG80 BNBG 9661 1020 3456 78";
        ulong creditcardOne = 4716940600918530u;
        ulong creditcardTwo = 4916745232880836u;
        ulong creditcardThree = 4916194369591561u;
        Console.WriteLine("Holder name: {0}",holderName);
        Console.WriteLine("Money balance: {0:c}",moneyBalance);
        Console.WriteLine("Bank name: {0}",bankName);
        Console.WriteLine("IBAN: {0}",uniqueIBAN);
        Console.WriteLine("Credit card № 1: {0}",creditcardOne);
        Console.WriteLine("Credit card № 2: {0}",creditcardTwo);
        Console.WriteLine("Credit card № 3: {0}",creditcardThree);



    }
}
