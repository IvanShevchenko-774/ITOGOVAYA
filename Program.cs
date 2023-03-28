class Program 
{
    static void Main(string[] args) 
    {
        
        Console.Write("Введите элементы массива через пробел: ");
        string[] inputArray = Console.ReadLine().Split(' ');
        string[] outputArray = new string[inputArray.Length];
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++) 
        {
            if (inputArray[i].Length <= 3) 
            {
                outputArray[count] = inputArray[i];
                count++;
            }
        }