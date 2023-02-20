using ElsysConnect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElsysConnect.Web.Models.ElsysConnectModel
{
    public class CandidateViewModel : BaseEntity
    {        
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
    }
}
