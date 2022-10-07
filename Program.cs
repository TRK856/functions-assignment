#nullable disable
List<int> nums = new List<int> { 2, 4, 6, 8, 10 };

// returns true
if (intContains(nums, 8))
{
    Console.WriteLine("8 is IN the List");
}
else
{
    Console.WriteLine("8 is NOT in the List");
}

// returns index
int index = indexOfInt(nums, 8);
if (index != -1)
{
    Console.WriteLine($"8 IN list at index: {index}");
}
else
{
    Console.WriteLine("8 NOT in list");
}

// returns reversed array
writeList(reverseInt(nums));
Console.WriteLine("---------\nswap\n--------");
swapInt(nums, 2, 4);
writeList(nums);

// nums -> [2, 4, 10, 8, 6]

void writeList(List<int> anArray)
{
    for (int i = 0; i < anArray.Count(); i++)
    {
        Console.WriteLine(anArray[i]);
    }
}

bool intContains(List<int> anArray, int find)
{
    for (int i = 0; i < anArray.Count(); i++)
    {
        if (anArray[i] == find)
        {
            return true;
        }
    }
    return false;
}

// bool stringContains(List<string> anArray, string find)
// {
//     for (int i = 0; i < anArray.Count(); i++)
//     {
//         if (anArray[i] == find)
//         {
//             return true;
//         }
//     }
//     return false;
// }

int indexOfInt(List<int> anArray, int find)
{
    for (int i = 0; i < anArray.Count(); i++)
    {
        if (anArray[i] == find)
        {
            return i;
        }
    }
    return -1;
}

int indexOfString(List<string> anArray, string find)
{
    for (int i = 0; i < anArray.Count(); i++)
    {
        if (anArray[i] == find)
        {
            return i;
        }
    }
    return -1;
}

List<int> reverseInt(List<int> anArray)
{
    List<int> reverse = new List<int> { };
    int count = 0;
    for (int i = anArray.Count() - 1; i >= 0; i--)
    {
        reverse.Add(anArray[i]);
        count++;
    }
    return reverse;
}

// List<string> reverseString(List<string> anArray) {
//     List<string> reverse = new List<string> {};
//     int count = 0;
//     for (int i = anArray.Count(); i >anArray.Count(); i--)
//     {
//         count++;
//         reverse[count] = anArray[i];
//     }
//     return reverse;
// }

void swapInt(List<int> anArray, int index1, int index2)
{
    int store = anArray[index1];
    anArray[index1] = anArray[index2];
    anArray[index2] = store;
}

// void swapString(List<string> anArray, int index1, int index2)
// {
//     string store = anArray[index1];
//     anArray[index1] = anArray[index2];
//     anArray[index2] = store;
// }

