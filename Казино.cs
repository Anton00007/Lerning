int balance = 1000;
Console.Write("balance: ");
Console.WriteLine(balance);
Random rand = new Random();
int bet1 = 0;

while (balance > 0)
{
    Console.WriteLine("Input bet:");
    string bet = Console.ReadLine();
    if (bet == "exit")
    {
        Console.Write("balance: ");
        Console.WriteLine(balance);
        break;
    }
    else
    {
        bet1 = Convert.ToInt32(bet);
        if (bet1 > balance)

        {
            Console.WriteLine("You don't have enough funds.");
            Console.WriteLine("Your balance: "); Console.WriteLine(balance);
        }
        else
        {
            bool A = true;
            while (A)
            {
                Console.WriteLine("Input your number: 0 or 1");
                string num1 = Console.ReadLine();
                if (num1 == "0" || num1 == "1")
                {
                    A = false;
                    int num = Convert.ToInt32(num1);
                    int randomValue = rand.Next(0, 2); // Сгенерировать рандомное число
                    Console.WriteLine(randomValue);
                    if (num == randomValue)
                    {
                        balance = balance + bet1;
                        Console.WriteLine("You win");
                    }
                    else
                    {
                        balance = balance - bet1;
                        Console.WriteLine("You lose");
                    }
                }
                else
                {
                    Console.WriteLine("the value entered is incorrect, you can only enter 0 or 1");
                }
            }
            Console.Write("balance: ");
            Console.WriteLine(balance);
        }
    }

}
Console.Write("Game over");
Console.ReadLine();