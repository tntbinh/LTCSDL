using System;
using System.Collections.Generic;

namespace news.DAL.Models
{
    public partial class DemId
    {
        public string CountId { get; set; }

        internal void SetError(string stackTrace)
        {
            throw new NotImplementedException();
        }
    }
}
