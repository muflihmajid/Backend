using System;
using SceletonAPI.Domain.Infrastructures;

namespace Solusindo.ApiBackend.Domain.Entities
{
    public class Token : BaseEntity
    {
        public string TaskName { get; set; }
        public string Deskripsi { get; set; }
        public DateTime? Deadline { get; set; }
     }
}
