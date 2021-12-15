﻿using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ShoppingCartAPI.Models.Dto
{
    public class CartHeaderDto
    {
        public int HeaderId { get; set; }

        public string UserId { get; set; }

        public string CouponCode { get; set; }
    }
}