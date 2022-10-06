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
if (index != -1) {
  Console.WriteLine($"8 IN list at index: {index}");
} else {
  Console.WriteLine("8 NOT in list");
}

// returns reversed array
List<int> reversedNums = reverse(nums);
Console.WriteLine(reversedNums);


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

bool stringContains(List<string> anArray, string find)
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

int indexOfInt(List<int> anArray, int find) {
    for (int i = 0; i < anArray.Count(); i++)
    {
        if (anArray[i] == find)
        {
            return i;
        }
    }
    return -1;
}

int indexOfString(List<string> anArray, string find) {
    for (int i = 0; i < anArray.Count(); i++)
    {
        if (anArray[i] == find)
        {
            return i;
        }
    }
    return -1;
}

List<string> reverse(List<string> anArray) {
    List<string> reverse;
    for (int i = anArray.Count(); i >anArray.Count(); i--)
    {
        reverse.Add(anArray[i]);
    }
    return anArray;
}