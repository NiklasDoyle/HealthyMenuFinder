using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace HealthyMenuFinder
{
    public partial class CaloriesPage : System.Web.UI.Page
    {
        string ingredients;
        string type;
        protected void Page_Load(object sender, EventArgs e)
        {
            ingredients = Request.QueryString["Scr"];
            type = Request.QueryString["Type"];
            Label1.Text = type + "     " + ingredients;

            string URL = @"https://api.spoonacular.com/recipes/findByIngredients?ingredients=apples,+flour,+sugar&number=2";
            /*
             * request.Headers.Add("X-RapidAPI-Host", "lexper.p.rapidapi.com");
                request.Headers.Add("X-RapidAPI-Key", "cae369fc12mshbb0dcf913fa132cp10e978jsn68b4acdbd1dd");
             */

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();


            Console.WriteLine(responsereader);
            RootObject rootObj = JsonConvert.DeserializeObject<RootObject>(responsereader);

        }
    }

    public class Ingredients
    {
        public string aisle { get; set; }
        public double amount { get; set; }
        public string id { get; set; }
        public string image { get; set; }
        //public List<Meta> meta { get; set; }
        public string name { get; set; }
        public string original { get; set; }
        public string originalName { get; set; }
        public string unit { get; set; }
        public string unitLong { get; set; }
        public string unitShort { get; set; }

    }

    public class Recipes
    {
        public string id { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
        public int likes { get; set; }
        public int missedIngredientCount { get; set; }
        public List<Ingredients> missedIngredients { get; set; }
        public string title { get; set; }
        public List<Ingredients> unusedIngredients { get; set; }
        public int usedIngredientCount { get; set; }
        public List<Ingredients> usedIngredients { get; set; }

    }
    public class RootObject
    {
        public List<Recipes> recipes { get; set; }

    }
}