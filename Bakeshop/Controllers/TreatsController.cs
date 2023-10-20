using Microsoft.AspNetCore.Mvc;
using Bakeshop.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Bakeshop.Controllers
{
  // [Authorize]
  public class TreatsController : Controller
  {
    private readonly BakeshopContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public TreatsController(UserManager<ApplicationUser> userManager, BakeshopContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    
    public ActionResult Index()
    {
      return View(_db.Treats.ToList());
    }
  }
}