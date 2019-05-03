using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class log : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Startup stp = new Startup();
            //Response.Redirect("http://192.168.1.80/mesa");
            Response.Redirect("https://accounts.google.com/signin/oauth/oauthchooseaccount?client_id=973705564392-fkmhp8564dej2j9i2pai74lfrno3j2sl.apps.googleusercontent.com&as=_arHSSUKWufr3RBoVC9wZA&destination=https%3A%2F%2Flocalhost%3A44372&approval_state=!ChRkcDlRRjhsSnY3aWpqQXBQSG5jSBIfOHdjMi1GczhNTmNhRUZvSEdUZHlJLTJOaC1XdnBSWQ%E2%88%99AJDr988AAAAAXMSlC4Hn_oDtxbTkHZpGj9zZ1bLBbAHW&oauthgdpr=1&xsrfsig=ChkAeAh8T6D8uIC-OIfHG0CVcBi4uTttUzXGEg5hcHByb3ZhbF9zdGF0ZRILZGVzdGluYXRpb24SBXNvYWN1Eg9vYXV0aHJpc2t5c2NvcGU&flowName=GeneralOAuthFlow");
        }
    }
}