using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class CommunityFood
    {
        public string FoodName { get; set; }
        public string UserName { get; set; }
        //public Image FoodImage { get; set; }
        public CommunityFood(string name, string username/*, Image image*/)
        {
            FoodName = name;
            UserName = username;
            //FoodImage = image;
        }
    }
}
