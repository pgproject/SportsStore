using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsStore.WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItms { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPage
        {
            get { return (int)Math.Ceiling((decimal)TotalItms / ItemsPerPage); }
        }
    }
}