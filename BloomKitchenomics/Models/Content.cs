using System;
using System.Collections.Generic;
using System.Text;

namespace BloomKitchenomics.Models
{
    public class Content
    {
        public string ContentTitle { get; set; }
        public string ContentType { get; set; }
        public int Pages { get; set; }
        public string ContentImage { get; set; }
        public bool IsVideo { get; set; }
    }
}
