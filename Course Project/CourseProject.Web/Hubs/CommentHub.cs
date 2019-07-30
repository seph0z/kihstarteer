using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Web.Hubs
{
    public class CommentHub : Hub
    {
        public async Task SendMessage(string user, string message, int projectId)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, projectId);
        }
    }
}
