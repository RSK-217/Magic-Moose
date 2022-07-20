
List<string> responses = new() { 
 "As I see it, yes.",
 "Ask again later.",
 "Better not tell you now.",
 "Cannot predict now.",
 "Concentrate and ask again.",
 "Don’t count on it.",
 "It is certain.",
 "It is decidedly so.",
 "Most likely.",
 "My reply is no.",
 "My sources say no.",
 "Outlook not so good.",
 "Outlook good.",
 "Reply hazy, try again.",
 "Signs point to yes.",
 "Very doubtful.",
 "Without a doubt.",
 "Yes.",
 "Yes – definitely.",
 "You may rely on it."
};

while (true) 
{
Console.WriteLine("Ask a question, any question.");
string userQuestion = Console.ReadLine();

if (userQuestion == "")
    {
        break;
    }

Console.WriteLine();
var random = new Random();
int index = random.Next(responses.Count);
Console.WriteLine(responses[index]);
}

Console.ReadLine();