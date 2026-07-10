public class Solution
{
    public bool AsteroidsDestroyed(int mass, int[] asteroids)
    {
        Array.Sort(asteroids);

        long currentMass = mass;

        for (int i = 0; i < asteroids.Length; i++)
        {
            if (asteroids[i] <= currentMass)
            {
                currentMass += asteroids[i];
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}