using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      IndexMessage newMessage = new IndexMessage()
      {
        Message = "This is a Message!",
        MessageContent = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Pariatur, autem inventore nemo ex at mollitia quibusdam minus odio consequatur adipisci cupiditate culpa tempora suscipit praesentium? Sequi possimus natus suscipit velit? Lorem ipsum dolorsit amet consectetur adipisicing elit. Pariatur, autem inventore nemo ex at mollitia quibusdam minus odio consequatur adipisci cupiditate culpa tempora suscipit praesentium? Sequi possimus natus suscipit velit?"
      };
      return View(newMessage);
    }

    [HttpGet("number")]
    public IActionResult Number()
    {
      NumberMessage newNumMessage = new NumberMessage()
      {
        Message = "Here are some numbers!",
        NumNumber = new int[] { 1, 2, 3, 10, 43, 5 }
      };
      return View(newNumMessage);
    }

    [HttpGet("users")]
    public IActionResult Users()
    {
      UsersMessage newUserMessage = new UsersMessage()
      {
        Message = "Here are some Users!",
        Names = new string[] {"Moose Phillips", "Sarah", "Jerry", "Rene Ricky", "Barbarah"}
      };
        return View(newUserMessage);
    }

    [HttpGet("user")]
    public IActionResult SingleUser()
    {
      UserMessage newUserMessage = new UserMessage()
      {
        Message="Here is a User!",
        Name = "Moose Phillips"
      };
      // string[] users = new string[]
      // {
      //   "Moose Phillips"
      // };
      return View(newUserMessage);
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