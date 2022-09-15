//Exercise 1
#region
var favNum = new Random();
var favNumber = favNum.Next(1, 1000);
Console.WriteLine("Hello again! Real quick I need you to guess what number I am thinking of. Between 1-1000");
var userInput = int.Parse(Console.ReadLine());

if (favNumber < userInput)
{
    Console.WriteLine("Your guess was too high, better luck next time.");
} 

else if (favNumber > userInput)
{
    Console.WriteLine("Looks like it's too low, oh well!");
}

else
{
    Console.WriteLine("Yes that's correct. Congratulations!!!"); 
}
#endregion

//Exercise 2
#region
const string math = "math";
const string history = "history";
const string science = "science";
const string pe = "pe";
const string english = "english";
Console.WriteLine();

Console.WriteLine("If you wouldn't mind, tell me what your favorite school subject is?");
var Answer = Console.ReadLine();

switch (Answer.ToLower())
{
    case english:
        Console.WriteLine("So English is your favorite subject, huh... I would nt agree.");
        break;
    case math:
        Console.WriteLine("Math! Now that's a subject I can get behind.");
        break;
    case history:
        Console.WriteLine("You know, I'n not a big history buff but I enjoy the stories.");
        break;
    case pe:
        Console.WriteLine("I'm not sure this is technically a subject, but I do injoy it as well.");
        break;
    case science:
        Console.WriteLine("Science is a fan favorite here, I love this subject");
        break;
    default:
        Console.WriteLine("I don't know what course this is, lets stick to the core subjects");
        break;


}








#endregion