﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ListBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource1.DeleteCommand = "DELETE from Books where Id=@Id";
            SqlDataSource1.UpdateCommand = "UPDATE Books SET Title=@Title,Author = @Author,Description= @Description,Quantity = @Quantity,Status = @Status, Price = @Price where Id = @Id";

        }
    }
}