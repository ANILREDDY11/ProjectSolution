using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSolution.Models
{
    public class BlogCard
    {

        public string BlogId { get; set; }

        public string BlogTitle { get; set; }

        public string BlogImage { get; set; }

        public string Posteddate { get; set; }

        public string Category { get; set; }

        public string ShortDesc { get; set; }
        public string imgsrc { get; set; }

        public string imgalt { get; set; }


        public BlogCard(String BlogId, String BlogTitle, string Posteddate,string ShortDesc,string imgsrc,string imgalt) {

            this.BlogId = BlogId;
            this.BlogTitle = BlogTitle;
            this.BlogImage = BlogImage;
            this.Posteddate = Posteddate;
            this.ShortDesc = ShortDesc;
            this.imgsrc = imgsrc;
            this.imgalt = imgalt;
         }

        

    }
}