using DDDSkeleton.Common.Domain;
using GlobalEventFileLog.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalEventFileLog.Domain.Environment
{
    public class Environment : EntityBase<int>
    {
        public EnvironmentID EnvironmentId { get; private set; }
        public EnvironmentName EnvironmentName { get; private set; }

        public Environment(int environmentId, String environmentName) 
        {
            EnvironmentId = new EnvironmentID(environmentId);
            EnvironmentName = new EnvironmentName(environmentName);
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }

    }
}
