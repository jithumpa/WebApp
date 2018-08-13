using System;
using System.Web;

namespace WebApp.Domain.Entities
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
            this.CreatedDate = this.ModifiedDate = DateTime.UtcNow;

            if (HttpContext.Current != null && HttpContext.Current.User != null)
            {
                this.CreatedBy = this.ModifiedBy = HttpContext.Current.User.Identity.Name;
            }

            this.IsArchived = false;
        }

        public int Id { get; set; }

        public bool IsArchived { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }
    }
}
