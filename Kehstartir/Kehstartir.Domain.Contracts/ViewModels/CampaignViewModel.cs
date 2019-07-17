using System;
using System.Collections.Generic;
using System.Text;

namespace Kehstartir.Domain.Contracts.ViewModels
{
    public class CampaignViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleLogo { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string VideoLink { get; set; }
        public double Amount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Theme { get; set; }
        public string UserId { get; set; }
        //public string UserName { get; set; }
        public string[] Tags { get; set; }
        //public string[] Comments { get; set; }
        //public string[] Images { get; set; }
        //public string[] Bonuses { get; set; }
        //public string[] Posts { get; set; }
        public double Rating { get; set; }
    }
}
