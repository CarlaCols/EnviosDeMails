using System.Collections.Generic;
using System.Text;

namespace EnviosMails
{
    public class EmailBody
    {
        public string mailUser { get; set; }
        public string mailPass { get; set; }
        public string mailCc { get; set; }
        public string mailCco { get; set; }
        public string To { get; set; }
        public string OpenBy { get; set; }

        //public string abiertoPor { get; set; }
        public string IdInteraction { get; set; }
        public string Title { get; set; }
        public string mailBody { get; set; }



        public List<groupDescriptions> groupDescriptions { get; set; } = new List<groupDescriptions>();
    }
    public class groupDescriptions
    {
        public string IdInteraction { get; set; }
        public string Title { get; set; }
    }
}
