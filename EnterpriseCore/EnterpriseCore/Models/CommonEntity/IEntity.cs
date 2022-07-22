using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnterpriseCore.Models
{
    public interface IEntity
    {
        long? GetIdentity();
        void SetIdentity(object id);
    }
}