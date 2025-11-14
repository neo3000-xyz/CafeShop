< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >
  using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
vvusing System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
vusing System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
namespace CafeShopWeb.wwwroot.lib
{
    public class exception
    {
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
vvusing System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
vusing System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web_CoffeeShop.Models;

namespace Web_CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
namespace CafeShopWeb.wwwroot.lib
{
    public class exception
    {
    }
}

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
vv < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
vv < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
vv < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v < Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
< Project Sdk = "Microsoft.NET.Sdk.Web" >

  < PropertyGroup >
    < TargetFramework > net8.0 </ TargetFramework >
    < Nullable > enable </ Nullable >
    < ImplicitUsings > enable </ ImplicitUsings >
  </ PropertyGroup >

  < ItemGroup >
    < PackageReference Include = "Microsoft.EntityFrameworkCore.SqlServer" Version = "9.0.10" />
    < PackageReference Include = "Microsoft.EntityFrameworkCore.Tools" Version = "9.0.10" >
      < PrivateAssets > all </ PrivateAssets >
      < IncludeAssets > runtime; build; native; contentfiles; analyzers; buildtransitive </ IncludeAssets >
    </ PackageReference >
  </ ItemGroup >

</ Project >
v