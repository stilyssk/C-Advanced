
namespace Generic_Box_of_Integer
{
    class Box<T>
    {
        private T inputData; 
        public Box(T inputString)
        {
            inputData = inputString;
        }


        public T InputData
        {
            get { return this.inputData; }
            set { this.inputData = value; }
        }


        public override string  ToString()
        {

            string result = $"{inputData.GetType()}: {inputData}";
            return result;
        }
    }
}
