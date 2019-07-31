using CourseProject.Domain.Contracts;
using CourseProject.Domain.Contracts.ViewModels;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Web.Hubs
{
    public class CommentHub : Hub
    {
        private readonly ICommentService commentService;
        public CommentHub(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        public async Task SendMessage(string user, string message, int projectId, string userImage, string userId)
        {
            string timeString = DateTime.Now.ToString("U", CultureInfo.CreateSpecificCulture("en-US"));
            commentService.Add(new CommentViewModel
            {
                Text = message,
                Create = DateTime.Parse(timeString),
                UserId = userId,
                ProjectId = projectId
            });

            await Clients.All.SendAsync("ReceiveMessage", user, message, timeString, userImage);
        }
    }
}
