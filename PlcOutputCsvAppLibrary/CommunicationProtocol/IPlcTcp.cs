namespace PlcOutputCsvAppLibrary
{
    public interface IPlcTcp
    {
        bool IsConnected { get; }

        void Connected(string ip, int port);
        void Disconnect();
        int[] ReadHoldingRegisters(int startingAddress, int quantity);
    }
}