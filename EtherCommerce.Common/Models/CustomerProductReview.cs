﻿using System;

namespace EtherCommerce.Common.Models
{
    public class CustomerProductReview
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Rating { get; set; }
        public string Title { get; set; }
        public string ReviewText { get; set; }
        public DateTime CreatedAt { get; set; }

        public bool IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public string ReplyText { get; set; }
    }
}