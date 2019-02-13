
namespace Generic_Box_of_Integer
{
    class Box<T>
    {
        private static T inputText; 
        public Box(T inputString)
        {
            inputText = inputString;
        }

        public override string  ToString()
        {

            string result = $"{inputText.GetType()}: {inputText}";
            return result;
        }
    }
}
