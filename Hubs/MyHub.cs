﻿using Microsoft.AspNetCore.SignalR;

namespace WebApplication1.Hubs
{
    public class MyHub:Hub
    {
        public async Task SendMessageAsync(string message)
        {
            await Clients.All.SendAsync("receiveMessage", message);
        }
    }
}
