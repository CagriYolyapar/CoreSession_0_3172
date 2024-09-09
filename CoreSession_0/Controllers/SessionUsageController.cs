using Microsoft.AspNetCore.Mvc;

namespace CoreSession_0.Controllers
{

  


    public class SessionUsageController : Controller
    {


        void SetSession()
        {
            //Session olusturuyorsunuz.Oncelikle olusturacagınız Session'in anahtarını yazıyorsunuz...Sonra icinde hangi veriyi saklamak istediginizi yazıyorsunuz...
            HttpContext.Session.SetString("Cagri", "Deneme");
        }

        string GetSession()
        {
            //GetString ile Cagri anahtarına sahip olan session'i cagırıyoruz...
            return HttpContext.Session.GetString("Cagri");
        }


        public IActionResult Index()
        {
            SetSession();
            ViewBag.Message = GetSession();
            

            return View();
            //Home/Index


            
        }
    }
}
