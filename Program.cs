using System;

namespace Magic8Ball
{
  class Program
  {
    public static void Main(string[] args)
    {
      string[] responses = 
      {
        "Yes", "No", "Maybe", "Come back later",
        "Haha! your funny!", "Go be a painter",
        "Not a chance", "Very likely", "You will be single forever",
        "Dont even think about it", "Thats just stupid"
      };

      Console.WriteLine("Welcome to my Magic 8 Ball!");
      Console.WriteLine("Ask any yes or no question you want and press Enter");
      string? question = Console.ReadLine();

      Random random = new Random();
      int index = random.Next(responses.Length);
      string answer = responses[index];

      Console.WriteLine($"Magic 8 Ball says: {answer}");

    }
  }
}