// string[] wordsArray = {"hello", "2", "world", ":-)"};
string[] wordsArray = {"1234", "1567", "-2", "computer science"};
// string[] wordsArray = {"Russia", "Denmark", "Kazan"};

string[] max3Digits = new string[wordsArray.Length];
int count = 0;

foreach (string i in wordsArray)
{
    if (i.Length <= 3)
    {
        max3Digits[count] = i;
        count++;
    }
}
Array.Resize(ref max3Digits, count);

Console.Clear();
PrintArray(wordsArray);
Console.Write(" -> ");
PrintArray(max3Digits);

/////////////////////////

static void PrintArray(string[] array)
    {
        Console.Write("[");
        if (array.Length != 0)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]},  ");
            }
            Console.Write(array[array.Length - 1]);
        }
        Console.Write("]");
    }