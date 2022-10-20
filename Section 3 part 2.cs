using System.Linq;

string[] RemoveDuplicates(string[] array)
{
    return array.Distinct().ToArray();
}