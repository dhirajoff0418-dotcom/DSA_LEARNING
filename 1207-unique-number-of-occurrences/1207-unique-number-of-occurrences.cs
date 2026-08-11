public class Solution 
{
    public bool UniqueOccurrences(int[] arr) 
    {
        var myMap = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            if (myMap.ContainsKey(num))
                myMap[num]++;
            else
                myMap[num] = 1;
        }
        var seenCounts = new HashSet<int>();
        foreach (var count in myMap.Values)
        {
            if (seenCounts.Contains(count))
                return false; 
            seenCounts.Add(count);
        }
        return true;
    }
}
