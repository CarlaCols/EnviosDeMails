using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviosMails
{
    public class dateToSendEmails
    {
        public string nis { get; set; }
        public string abiertoPor { get; set; }
        public List<groupDescriptionsD> groupDescriptions { get; set; } = new List<groupDescriptionsD>();
    }
    public class groupDescriptionsD
    {
        public string idInteraccion { get; set; }
        public string titulo { get; set; }
    }
}
