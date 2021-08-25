//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using Sitecore;
//using Sitecore.Data.Items;
//using Sitecore.Resources.Media;
//using ProjectSolution.Models;



//namespace ProjectSolution.Controllers
//{
//    public class SearchController : Controller
//    {
//        // GET: Search
//        public ActionResult Index()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult searchPredicate(FormCollection form)
//        {
//            string query = form["searchInput"];
//            List<Sitecore.Data.Items.Item> blogItems = new List<Sitecore.Data.Items.Item>();
//            List<BlogCard> BlogCardsCollection = new List<BlogCard>();
//            var rootitem = Sitecore.Context.Database.GetItem("{{E01FF4BB-1481-4D8D-9AC8-7E221C27E665}}}");
//            var Websitesettings = Sitecore.Context.Database.GetItem("{3A399232-1218-4AA2-B544-98AEB9821223}");
//            blogItems = rootitem.Axes.GetDescendants().ToList();

           

//            for (int i = 0; i < blogItems.Count; i++)
//            {
//                BlogCard BlogModel = new BlogCard();
//                var imageUrl = string.Empty;

//                Sitecore.Data.Fields.ImageField imageField = blogItems[i].Fields["ArticleSmallImage"];
//                if (imageField?.MediaItem != null)
//                {
//                    var image = new MediaItem(imageField.MediaItem);
//                    imageUrl = StringUtil.EnsurePrefix('/', MediaManager.GetMediaUrl(image));
//                    BlogModel.BlogSImage = imageUrl;
//                }
//                BlogModel.Category = blogItems[i].Fields["Category"].Value;
//                BlogModel.BlogTitle = blogItems[i].Fields["Title"].Value;

//                Sitecore.Data.Fields.DateField dateTimeField = blogItems[i].Fields["PostedDate"];

//                string dateTimeString = dateTimeField.Value;

//                DateTime dateTimeStruct = Sitecore.DateUtil.IsoDateToDateTime(dateTimeString);
//                BlogModel.date = dateTimeStruct.ToShortDateString();

//                BlogModel.ShortDesc = blogItems[i].Fields["ShortDescription"].Value;
//                BlogModel.LongDesc = blogItems[i].Fields["LongDescription"].Value;
//                BlogModel.Readonbtn = Websitesettings.Fields["BlogCardButtonText"].Value;
//                BlogModel.sitecoreItem = blogItems[i];
//                BlogModel.BlogURL = Sitecore.Links.LinkManager.GetItemUrl(blogItems[i]);


//                BlogCardsCollection.Add(BlogModel);
//            }

//            if (query is null)
//                query = "hi";

//            List<BlogCard> results = BlogCardsCollection.FindAll(Findtitle);



//            bool Findtitle(BlogCard bk)
//            {

//                if (bk.BlogTitle.Contains(query) || bk.Category.Contains(query) || bk.ShortDesc.Contains(query) || bk.LongDesc.Contains(query))
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }

//            ViewBag.searchCards = results;
//            return View("~/Views/ProjectDetails/Search.cshtml", ViewBag.searchCards);
//        }
//    }
//}
    
