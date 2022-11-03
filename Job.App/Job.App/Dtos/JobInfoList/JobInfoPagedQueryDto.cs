using Job.App.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.App.Dtos.JobInfoList
{
    public class JobInfoPagedQueryDto : PagedQueryDto
    {
        public string Title { get; set; }

        public string Type { get; set; }

        public string Category { get; set; }
        public string Workplace { get; set; }

        public List<string> ContentCheck { get; set; }
    }
}
