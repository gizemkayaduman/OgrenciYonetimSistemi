using Microsoft.AspNetCore.Mvc;

namespace OgrenciYonetimSistemi.Controllers
{
    [Route("BolumSekreteri")]
    public class BolumSekreteriController : Controller
    {
        [Route("OgrenciEkleCikar")]
        public IActionResult OgrenciEkleCikar()
         {
            return View();
         }
        
    }
}
