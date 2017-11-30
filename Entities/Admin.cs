using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAS.Entities
{
    class Admin: User
    {
        public int Uid { get; set; }
        public string AName { get; set; }
    }
}
