using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Services.Commands;

namespace Services
{

    public class RdgWebSocket
    {
        //Initialize variables
        private ClientWebSocket _client = new ClientWebSocket();
        private CancellationTokenSource _ct = new CancellationTokenSource();
        private bool _isConnected = false;

        public bool IsConnected
        {
            get => _client.State == WebSocketState.Open;
        }

        //Constructor Performing initialize web socket
        public RdgWebSocket()
        {
            WebSocketCommands.Socket = this;
            _client.Options.KeepAliveInterval = Timeout.InfiniteTimeSpan;
        }
        
        //Performing a web socket opening
        public Task? ConnectAsync(string ipAddress, int port)
        {
            try
            {
                return _client.ConnectAsync(new Uri("ws://" + ipAddress + ":" + port + "/"),
                    _ct.Token);
            }
            catch
            {
                throw new InvalidOperationException("Error trying connect to web socket!");
            }
        }

       
        //Performing a web socket closure
        public Task? CloseAsync()
        {
            try
            {
                _ct.Cancel();
                _client.Abort();
                return null;
            }
            catch
            {
                throw new InvalidOperationException("Error trying to close web socket!");
            }
        }
        
        //Performing a sending query
        public void SendQuery(string query)
        {
            var message = new ArraySegment<byte>(System.Text.Encoding.UTF8.GetBytes(query));
            var buffer = new ArraySegment<byte>(new byte[16024]);
        
            _client.SendAsync(message, WebSocketMessageType.Text, true, _ct.Token);
        }
        
        //Performing a reading message
        public string? ReadMessage() {
            try {
                
                byte[] buffer = new byte[16024];
                 if (!(_client.State == WebSocketState.Open)) return null;
                var result =  _client.ReceiveAsync(buffer, _ct.Token);
                int receiveCount = result.Result.Count;
                string respond = Encoding.UTF8.GetString(buffer, 0, receiveCount);
                OnMessageEventArgs args = new OnMessageEventArgs();
                args.Message = respond;
                OnMessageReached(args);
                return respond;
            }
            catch {
                return null;
            }
        }
        
        //Method returning the state of the web socket
        public WebSocketState GetWebSocketState()
        {
            return _client.State;
        }

        //Performing a listening on for the web socket
        public Task Listen()
        {
            return Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Thread.Sleep(10);
                    ReadMessage();
                }
            }, _ct.Token);
        }
        
        //Handler of messages
        protected virtual void OnMessageReached(OnMessageEventArgs e)
        {
            OnMessageHandler? handler = MessageReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event OnMessageHandler? MessageReached;
        
        public class OnMessageEventArgs : EventArgs
        {
            public string Message { get; set; }
        }

        public delegate void OnMessageHandler(Object sender, OnMessageEventArgs e);
    
    }
}