
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using System.Linq;
public class PessoaController : Controller
{

  private readonly ISession _session;
        public PessoaController(ISession session)
        {
            _session = session;
        }
  public IActionResult Index()
  {
      var list = _session.Query<Pessoa>().ToList();
      return View(list);
  }
  public IActionResult Index2()
  {
    return View();
  }
  public IActionResult About()
  {
    return View();
  }
  public IActionResult Contact()
  {
    return View();
  }
  public IActionResult Error()
  {
    return View();
  }
}