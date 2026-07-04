public class Solution {
    public bool possibleToEat(int[] piles , int perHr, int h){
        int currCapacity=0;
        for(int i=0; i<piles.Length;i++){
            currCapacity += (piles[i] + perHr - 1) / perHr;
        }
       return currCapacity <= h;
    }
    public int MinEatingSpeed(int[] piles, int h) {
        int l=1;
        int r=piles.Max();

        while (l <r){
            int maxEat= l+ (r-l)/2;
            if(possibleToEat(piles,maxEat , h )){
                r=maxEat;
            }else{
                l=maxEat+1;
            }
        }
        return l;
    }
}