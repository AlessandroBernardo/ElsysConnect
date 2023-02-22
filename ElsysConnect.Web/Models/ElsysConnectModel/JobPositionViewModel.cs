using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElsysConnect.Web.Models.ElsysConnectModel
{
    public class JobPositionViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public DateTime? ClosingDate { get; set; }
    }
}
