using System;

namespace Comm
{
    internal class EventHandle
    {
        private Action<byte[]> comm_DataReceived;

        public EventHandle(Action<byte[]> comm_DataReceived)
        {
            this.comm_DataReceived = comm_DataReceived;
        }
    }
}