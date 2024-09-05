using EasyModbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlcOutputCsvAppLibrary
{
    public class ModbusTcp : IPlcTcp
    {
        private readonly ModbusClient _modbus = new ModbusClient();

        public bool IsConnected { get { return _modbus.Connected; } }

        public void Connected(string ip, int port)
        {
            try
            {
                _modbus.Connect(ip, port);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Disconnect()
        {
            try
            {
                _modbus.Disconnect();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int[] ReadHoldingRegisters(int startingAddress, int quantity)
        {
            try
            {
                return _modbus.ReadHoldingRegisters(startingAddress, quantity);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
