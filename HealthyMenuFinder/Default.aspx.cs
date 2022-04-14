using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthyMenuFinder
{
    public partial class Default : System.Web.UI.Page
    {
        string ingredients;
        Char[] trimStr = {',','+'};
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] words = TextBox2.Text.Split('\n');

            foreach (string word in words)
                ingredients += word + ",+";

            ingredients = ingredients.Trim(trimStr);

            Response.Redirect("CaloriesPage.aspx?Scr=" + ingredients + "&Type=Calories");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string[] words = TextBox2.Text.Split('\n');

            foreach (string word in words)
                ingredients += word + ",+";

            ingredients = ingredients.Trim(trimStr);

            Response.Redirect("CaloriesPage.aspx?Scr=" + ingredients + "&Type=Protein");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string[] words = TextBox2.Text.Split('\n');

            foreach (string word in words)  
                ingredients += word + ",+";

            ingredients = ingredients.Trim(trimStr);

            Response.Redirect("CaloriesPage.aspx?Scr=" + ingredients + "&Type=Both");

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text != "")
            {
                TextBox2.Text += TextBox1.Text + "\n";

                TextBox1.Text = "";
            }
            
        }
    }
}