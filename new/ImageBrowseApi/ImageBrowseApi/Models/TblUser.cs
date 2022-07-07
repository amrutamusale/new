using System;
using System.Collections.Generic;

#nullable disable

namespace ImageBrowseApi.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
