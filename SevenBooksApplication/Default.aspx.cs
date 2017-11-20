﻿using SevenBooksApplication.App_Code;
using System;
using System.Web.UI;


namespace SevenBooksApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //gvBook.DataSource = BusinessLogic.SearchAllBooks();
                //gvBook.DataBind();
                repBookList.DataSource = BusinessLogic.SearchAllBooks();
                repBookList.DataBind();
            }
        }
    }
}