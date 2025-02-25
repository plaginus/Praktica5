using System.ComponentModel;

public class GeometricProgression : IProgression
{
    public int startNumber {get; set;}
    public int increaseNumber {get; set;}

    public GeometricProgression(int startNumber, int increaseNumber)
    {
        this.startNumber = startNumber;
        this.increaseNumber = increaseNumber;
    }

    public int GetElement(int k)
    {
        checked
        {
            int result = (int)(startNumber * Math.Pow(increaseNumber, k - 1));
            return result;
        }
    }
}