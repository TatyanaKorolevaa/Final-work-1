// Примеры:
// ["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
// ["1234", "1567", "-2", "computer science"] → [“-2”]
// ["Russia", "Denmark", "Kazan"] → []

string[] array = {"Hello", "2", "world", ":-)"};
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array [i].Length < 4)
    {
        count++;
    }
}

string[] result = new string[count];

int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array [i].Length < 4)
    {
        result[j]=array[i];
        j++;
    }
}

for (int i = 0; i < result.Length; i++)
{
    Console.Write($"{result[i]}\t");
}


