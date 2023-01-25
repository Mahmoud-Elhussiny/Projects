using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeSystem.Application.Message
{
    public abstract class BaseRequest : BaseMassege
    {
        public BaseRequest() { }
        public BaseRequest(Guid correlationId) : base()
        {
            _correlationId = correlationId;
        }
    }
}
