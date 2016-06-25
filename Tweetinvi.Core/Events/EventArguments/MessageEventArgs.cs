﻿using System;
using Tweetinvi.Core.Interfaces;
using Tweetinvi.Models;

namespace Tweetinvi.Core.Events.EventArguments
{
    public class MessageEventArgs : EventArgs
    {
        public MessageEventArgs(IMessage message)
        {
            Message = message;
        }

        public IMessage Message { get; private set; }
    }
}