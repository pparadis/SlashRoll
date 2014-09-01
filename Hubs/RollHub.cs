using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

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