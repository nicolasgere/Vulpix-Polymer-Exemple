using Vulpix;
using Microsoft.AspNetCore.Http;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new VulpixServer();
            
            app.UseStaticFolder("Public");

            //entry point for polymer
            app.AddRoute("GET","/", (Req req, Res res)=>{
                 res.Response.SendFileAsync("Public/index.html");
            });

            //Add route
            var DataControlleur = new DataControlleur();
            app.AddRoute("GET","/Data",DataControlleur.GetData);   

            app.Listen(3000);
        }
    }
}
