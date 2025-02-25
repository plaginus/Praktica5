public class ArithmeticProgression : IProgression
{
    public int startNumber {get; set;}
    public int increaseNumber {get; set;}
    public ArithmeticProgression(int startNumber, int increaseNumber)
    {
        this.startNumber = startNumber;
        this.increaseNumber = increaseNumber;
    }

    public int GetElement(int k)
    {
        return startNumber + increaseNumber * (k - 1);
    }
}
