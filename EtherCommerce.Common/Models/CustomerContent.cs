using System;

namespace EtherCommerce.Common.Models
{
    public class CustomerContent
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public string IpAddress { get; set; }
        public DateTime CreatedAt { get; set; }

        public ApproveStatus Status { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public string ReplyText { get; set; }
    }


    public enum ApproveStatus
    {
        Pending = 1,
        Approved = 2,
        Rejected = 3
    }
}
