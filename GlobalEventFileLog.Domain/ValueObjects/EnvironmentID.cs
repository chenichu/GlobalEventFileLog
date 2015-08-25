using DDDSkeleton.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalEventFileLog.Domain.ValueObjects
{
    public class EnvironmentID : ValueObjectBase
    {
        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public int ID { get; private set; }

        public EnvironmentID(int id)
        {
            ID = id;
        }
    }
}
