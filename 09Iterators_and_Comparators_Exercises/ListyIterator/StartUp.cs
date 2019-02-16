
using System;
using System.Linq;

namespace ListyIterator
{

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var newListyIterator = new ListyIterator<string>();
            while (true)
            {
                
                var inputCommand = Console.ReadLine()
                    .Split(new[] {' ' },StringSplitOptions.RemoveEmptyEntries)
                    .ToList();


                if (inputCommand[0]== "END")
                {
                    break;
                }
                else
                {
                    switch (inputCommand[0])
                    {
                        case "Create":
                            inputCommand.RemoveAt(0);
                            newListyIterator=new ListyIterator<string>(inputCommand.ToArray());
                            break;
                        case "Move":
                            Console.WriteLine(newListyIterator.Move());
                            break;
                        case "Print":
                            newListyIterator.Print();
                            break;
                        case "PrintAll":
                            newListyIterator.PrintAll();
                            break;
                        case "HasNext":
                            Console.WriteLine(newListyIterator.HasNext());
                            break;
                        default:
                            break;
                    }
                }
            }
        }

    }
}
