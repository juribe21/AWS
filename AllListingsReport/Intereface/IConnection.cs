using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllListingsReport
{
    public interface IConnection
    {
        AWSAccessConfigurationDTO _awsAccess { get; set; }

        AWSAccessConfigurationDTO GetAccessConfiguration();
        //AWSAccessConfigurationDTO GetAccessConfiguration(string sellerid);
    }
}
