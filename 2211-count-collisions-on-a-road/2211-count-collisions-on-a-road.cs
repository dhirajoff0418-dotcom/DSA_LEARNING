// public class Solution {
//     public int CountCollisions(string directions) {
//         int count = 0;
//         char[] s = directions.ToCharArray();
//         int n = s.Length;
//         int i = 0;

//         while (i < n) {

//             // R and L collide
//             if (i + 1 < n && s[i] == 'R' && s[i + 1] == 'L') {
//                 count += 2;
//                 s[i] = 'S';
//                 s[i + 1] = 'S';
//                 i++;
//             }

//             // R hits S
//             else if (i + 1 < n && s[i] == 'R' && s[i + 1] == 'S') {
//                 count += 1;
//                 s[i] = 'S';
//                 i++;
//             }

//             // Already stationary
//             else if (s[i] == 'S') {
//                 i++;
//             }

//             // L hits S
//             else if (i > 0 && s[i] == 'L' && s[i - 1] == 'S') {
//                 count += 1;
//                 s[i] = 'S';
//                 i++;
//             }

//             // No collision
//             else {
//                 i++;
//             }
//         }

//         return count;
//     }
// }


public class Solution {
    public int CountCollisions(string directions) {
        int left = 0;
        int right = directions.Length - 1;

        // Starting L cars never collide
        while (left <= right && directions[left] == 'L') {
            left++;
        }

        // Ending R cars never collide
        while (left <= right && directions[right] == 'R') {
            right--;
        }

        int count = 0;

        // Every L/R in the remaining part will collide
        for (int i = left; i <= right; i++) {
            if (directions[i] != 'S') {
                count++;
            }
        }

        return count;
    }
}