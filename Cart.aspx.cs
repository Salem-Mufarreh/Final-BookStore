using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Context;

namespace WebApplication2
{
    public partial class Cart : System.Web.UI.Page
    {
        protected readonly ApplicationContext context = new ApplicationContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}