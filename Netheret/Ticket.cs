using System;
using System.Collections.Generic;
using System.Text;

namespace Netheret
{
    internal class Ticket
    {
        string Id;
        bool Open;
        int Status;
        int Priority;
        int Serverity;
        int Impact;
        string SenderId;
        string Content;
        DateTime Sent;
        DateTime Closed;

        public Ticket(string id, bool open, int status, int priority, int serverity, int impact, string senderId, string content, DateTime sent, DateTime closed)
        {
            Id = id;
            Open = open;
            Status = status;
            Priority = priority;
            Serverity = serverity;
            Impact = impact;
            SenderId = senderId;
            Content = content;
            Sent = sent;
            Closed = closed;
        }
    }
}
