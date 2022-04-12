using System;
using System.Diagnostics;
using System.Text.Json;
using Services.Commands.CommandModel;

namespace Services.Commands
{
    public static class WebSocketCommands
    {

        private static RdgWebSocket _socket;
        
        static WebSocketCommands(){}

        static public bool SendCommand(string commandName, string parameter)
        {
            try
            {
                _socket.SendQuery(JsonSerializer.Serialize(new Command(commandName, parameter)));
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
        static public bool SendKeyCommand(string commandName, string key, string parameter)
        {
            try
            {
                _socket.SendQuery(JsonSerializer.Serialize(new KeyCommand(commandName, parameter, key)));
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }
        
        static public bool SendDataKeyCommand(string commandName, string data, string key, string parameter)
        {
            try
            {
                _socket.SendQuery(JsonSerializer.Serialize(new DataKeyCommand(commandName, parameter, key, data)));
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return false;
            }
        }

        public static RdgWebSocket Socket
        {
            get => _socket;
            set => _socket = value;
        }
    }
}