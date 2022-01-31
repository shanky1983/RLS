using System;
using System.ComponentModel.DataAnnotations;


namespace Attune.KernelV2.Entities
{
    public class RefreshTokens
    {
        [Key]
        public string Id { get; set; }
         
        public string Subject { get; set; }
        [Required]
        public string ClientId { get; set; }
        public DateTime IssuedUtc { get; set; }
        public DateTime ExpiresUtc { get; set; }
        [Required]
        public string ProtectedTicket { get; set; }
    }
}