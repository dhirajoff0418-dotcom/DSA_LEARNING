public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int minimumBoat=0;
        int i=0;
        int j=people.Length-1;
        while( i <= j){
            if(people[i] + people[j] <=limit){
                i++;
                j--;
                minimumBoat++;
            }else{
                j--;
                minimumBoat++;
            }
        }
        return minimumBoat;
    }
}