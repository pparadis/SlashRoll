using Microsoft.AspNet.SignalR;
using System;
using System.Threading.Tasks;

namespace Slashroll.Hubs
{
    public class RollHub : Hub
    {
        public void Roll(string room, string name)
        {
            Clients.Group(room).addNewMessageToPage(name, "roll: " + new Random().Next(100));
        }

        public Task JoinRoll(string rollName)
        {
            return Groups.Add(Context.ConnectionId, rollName);
        }
    }
}