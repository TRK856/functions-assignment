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
