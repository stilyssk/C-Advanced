namespace Stack
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var listOfInt = new Stack<int>();
            while (true)
            {

                var inputCommand = Console.ReadLine()
                    .Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();


                if (inputCommand[0] == "END")
                {
                    break;
                }
                else
                {
                    switch (inputCommand[0])
                    {
                        case "Push":
                            inputCommand.RemoveAt(0);
                            int[] arrayOfInt = inputCommand
                                .Select(int.Parse)
                                .ToArray();
                            listOfInt.Push(arrayOfInt);
                            break;
                        case "Pop":
                            listOfInt.Pop();
                            break;                        
                        default:
                            break;
                    }
                }
            }
            foreach (var item in listOfInt)
            {
                Console.WriteLine(item);
            }
            foreach (var item in listOfInt)
            {
                Console.WriteLine(item);
            }
        }
    }
}
