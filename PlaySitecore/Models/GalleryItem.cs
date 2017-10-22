using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;

namespace PlaySitecore.Models
{
    public interface IGalleryItem
    {
        string Title { get; set; }
        string Description { get; set; }
        Image Image { get; set; }

    }
}