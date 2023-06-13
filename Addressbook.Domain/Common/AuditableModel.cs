using System;
namespace Addressbook.Domain.Common
{
    public class AuditableModel
    {
        public int CreateById { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
    }
}

