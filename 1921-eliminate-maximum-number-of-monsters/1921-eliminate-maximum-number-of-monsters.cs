public class Solution {
    public int EliminateMaximum(int[] dist, int[] speed) {
        //first we create an array of time speed=d/t and then sort beacuse to kill max monster we need to first kill who is fast beacuse if we kill the nearest one whose speed is slow the long with fast one get reached early

       int[] timeArr = new int[dist.Length];
        for (int i = 0; i < dist.Length; i++)
        {
            timeArr[i] = (dist[i] + speed[i] - 1) / speed[i];
        }
        Array.Sort(timeArr);
        int time=0;
        int monster=0;
        for (int i = 0; i < timeArr.Length; i++)
        {
            if (timeArr[i] - time <= 0)
            {
                return monster;
            }

            monster++;
            time++;
        }
        return monster;
    }
}