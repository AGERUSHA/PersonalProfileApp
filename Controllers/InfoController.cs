using Microsoft.AspNetCore.Mvc;
using PersonalProfileApp.Models;

namespace PersonalProfileApp.Controllers
{
    public class InfoController : Controller
    {
        // Студенттің мәліметтері бір жерде сақталады
        private static readonly StudentProfile Profile = new()
        {
            FullName = "Агадинова Ақерке Қайратқызы",
            Group = "ИСК 241",
            University = "Абай атындағы Қазақ Ұлттық Педагогикалық Университеті",
            Course = "3 курс студенті",
            Bio = "Мен веб-бағдарламалауды үйреніп жүрген студентпін. ASP.NET Core MVC арқылы заманауи веб-қосымшалар жасауға қызығамын.",
            Skills = new() { "C#", "ASP.NET Core MVC", "HTML / CSS", "JavaScript", "Bootstrap", "Git / GitHub", "SQL негіздері" },
            Email = "akerke250407@gmail.com",
            GitHub = "https://github.com/agerusha",
            Projects = new()
            {
                new() { Title = "PersonalProfileApp", Description = "ASP.NET Core MVC негізіндегі жеке ақпараттық визитка.", Technologies = "C#, ASP.NET Core MVC, Bootstrap" },
                new() { Title = "FirstMvcApp", Description = "Алғашқы MVC жобасы: StudentController, ViewBag арқылы деректер беру.", Technologies = "C#, ASP.NET Core MVC" },
                new() { Title = "Жеке веб-бет", Description = "HTML және CSS арқылы жасалған статикалық бет.", Technologies = "HTML, CSS" }
            }
        };

        // GET: /Info/ немесе /Info/Index — студент туралы негізгі мәлімет
        public IActionResult Index()
        {
            ViewBag.Message = "Менің жеке ақпараттық визиткама қош келдіңіз!";
            return View(Profile);
        }

        // GET: /Info/About — өзі туралы және дағдылары
        public IActionResult About()
        {
            return View(Profile);
        }

        // GET: /Info/Portfolio — жобалар мен байланыс ақпараттары
        public IActionResult Portfolio()
        {
            return View(Profile);
        }
    }
}
