using System;
using SceletonAPI.Domain.Infrastructures;

namespace SceletonAPI.Domain.Entities
{
    public class TokenData : BaseEntity
    {
        public string Token { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}
