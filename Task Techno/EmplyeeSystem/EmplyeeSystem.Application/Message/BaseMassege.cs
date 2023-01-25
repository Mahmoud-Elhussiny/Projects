using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeSystem.Application.Message
{
    public abstract class BaseMassege
    {
        protected Guid _correlationId = Guid.NewGuid();
        public Guid CorrelationId() => _correlationId;
    }
}
