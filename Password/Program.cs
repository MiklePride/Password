class program
{
    static void Main(string[] args)
    {
        string userPassword = "6584";
        int numberPasswordAttempts = 3;
        string userInput;
        for (int i = numberPasswordAttempts; i > 0; i--)
        {
            Console.WriteLine("Введите ультрасекретный пароль:");
            userInput = Console.ReadLine();
            if(userInput == userPassword)
            {
                Console.WriteLine("Доступ к секретным материалам пентагона открыт!");
                break;
            }
            else
            {
                numberPasswordAttempts--;
                Console.WriteLine($"у вас осталось {numberPasswordAttempts} попыток");
            }
        }
    }
}