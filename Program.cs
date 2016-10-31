using System;
using Vulpix;
using Microsoft.AspNetCore.Http;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new VulpixServer();
            
            app.UseStaticFolder("public");

            //entry point for polymer
            app.AddRoute("GET","/", (Req req, Res res)=>{
                 res.Response.SendFileAsync("public/index.html");
            });

            var DataControlleur = new DataControlleur();
            app.AddRoute("GET","/Data",DataControlleur.GetData);   

            app.Listen(3000);
        }
    }
}
