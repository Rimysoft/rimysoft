using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using rimysoft.Classes;

namespace rimysoft.Pages
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
            var db = new LoginDL();
            var users = db.Go();

            if(users != null){
                
            }


        }
    }
}
