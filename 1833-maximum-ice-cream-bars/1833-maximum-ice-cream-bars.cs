public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        int count =0;
        Array.Sort(costs);
        for(int i=0;i <costs.Length;i++){
            if(coins >0 && costs[i] <= coins){
                coins=coins-costs[i];
                count++;
            }else{
                break;
            }
        }
        return count;
    }
}