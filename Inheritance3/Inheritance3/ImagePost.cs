using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance3
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }
        public ImagePost() { }
        public ImagePost(string title, bool isPublic, string sendByUserName, string imageURL) : base(title, isPublic, sendByUserName)
        {
            //this.ID=GetNextID(); 
            //this.Title=title;
            //this.SendByUsername=sendByUserName;
            //this.IsPublic=isPublic;

            //property for imageUrl
            this.ImageURL=imageURL;

        }

        public override string ToString()
        {
            return base.ToString() +" "+ ImageURL;
        }
    }
}
