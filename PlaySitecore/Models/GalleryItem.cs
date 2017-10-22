using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace PlaySitecore.Models
{
    public interface IGalleryItem
    {
        [SitecoreId]
        Guid Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        Image Image { get; set; }

    }
}