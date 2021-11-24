// Deconstructor
var (address, isValid) = ValidateAddress("123 Entenhausen 424");

// Discard character
var (address2, _) = ValidateAddress("123 Entenhausen 424");

Console.WriteLine(isValid ? $"Validated address is {address}" : $"Invalid address.");

(string address, bool isValid) ValidateAddress(string address)
{
    const string validAddress = "123 Entenhausen 42";
    return address.Equals(validAddress) ? (validAddress, true) : (address, false);
}
