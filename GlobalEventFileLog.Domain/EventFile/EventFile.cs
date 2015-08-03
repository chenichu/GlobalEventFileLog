using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDSkeleton.Common.Domain;

namespace GlobalEventFileLog.Domain
{
    public class EventFile : EntityBase<int>, IAggregateRoot
    {
        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public string EventFileName { get; set; }

    }
}
