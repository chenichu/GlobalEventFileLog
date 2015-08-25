using DDDSkeleton.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalEventFileLog.Domain.ValueObjects
{
    public class EnvironmentName : ValueObjectBase
    {
        protected override void Validate()
        {
            throw new NotImplementedException();
        }

        public string Name { get; private set; }

        public EnvironmentName(string environmentName)
        {
            if (!string.IsNullOrEmpty(environmentName))
            {
                Name = environmentName;
            }
        }
    }
}
