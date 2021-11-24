string? info = null;

SayHi(info);


void SayHi(string message)
{
    // Shorter as "if" and shows Parameter in exception stack trace.
    ArgumentNullException.ThrowIfNull(message);  
    Console.WriteLine($"Hello {message}");
}

