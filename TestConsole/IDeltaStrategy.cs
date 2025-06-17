namespace TestConsole
{
    public interface IDeltaStrategy
    {
        (byte,byte) QuantiseDeltaToIndex(byte previousValue, byte nextValue);
    }

}
