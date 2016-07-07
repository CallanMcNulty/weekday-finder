using System;
using Nancy;

namespace weekdayFinder
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        string dateToConvert = Request.Form["date-string"];
        dateToConvert = dateToConvert.Substring(5, 2) + dateToConvert.Substring(8, 2) + dateToConvert.Substring(0, 4);
        Finder newDateToFind = new Finder();
        string newDateToDay = newDateToFind.Find(dateToConvert);
        return View["result.cshtml", newDateToDay];
      };
    }
  }
}
