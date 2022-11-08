using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cryptocurency_viewer.Data;

namespace Cryptocurency_viewer
{
    public class Rootobject
    {
        public Exchanges[] exchanges { get; set; }
        public Assets[] assets { get; set; }
        public Market[] market { get; set; }
    }
}
