using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnterpriseCore.Models
{
    [Serializable]
    public class BaseEntity : IEntity
    {
        private long? _Id = null;
        public virtual long? Id
        {
            get { return _Id; }
            set => _Id = value;

        }
        public virtual long? GetIdentity() { return this.Id; }
        public virtual void SetIdentity(object id)
        {
            this.Id = Convert.ToInt64(id);
        }

        public DateTime CreationDate { get; set; }
        public DateTime DeletionnDate { get; set; }
        public DateTime UpdatenDate { get; set; }
    }
}
