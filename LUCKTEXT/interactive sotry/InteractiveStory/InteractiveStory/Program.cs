
Console.WriteLine("What is your name?");

string Advname = Console.ReadLine();

Console.WriteLine("Welcome");

Console.WriteLine($"Choose a path {Advname}, right or left?");

string path = Console.ReadLine();

if (path == "left")
{

    Console.WriteLine("You arrive at a castle, do you enter? Yes or No");

    string enterorno = Console.ReadLine();

    if (enterorno == "yes")
    {

        Console.WriteLine("You are not allowed to enter pirvate property, you have been stabbed.");
    }
    else if (enterorno != "yes")
    {

        Console.WriteLine("You continue on with your day");
    }
}
else if (path == "right")
{

    Console.WriteLine("You chose the wrong path. A tiger starts chasing you, which weapon do you use, stick or knife?");
    {
    }
    string weaponchoice = Console.ReadLine();
    {
        Console.WriteLine($"Good luck with your {weaponchoice}");
    }

}
Console.ReadLine();
