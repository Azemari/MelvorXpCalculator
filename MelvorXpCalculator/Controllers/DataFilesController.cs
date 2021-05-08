using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using MelvorXpCalculator.Utilities;
using MelvorXpCalculator.Models;
using Newtonsoft.Json;
using System.Text;

namespace MelvorXpCalculator.Controllers
{
    public class DataFilesController : Controller
    {
        public IActionResult Skills()
        {
            var serializedData = JsonConvert.SerializeObject(Data.Retrieve<Skill>("DataFiles/Skills.json"));
            var byteArray = Encoding.UTF8.GetBytes(serializedData);
            Response.Headers.Add(HeaderNames.ContentDisposition, serializedData);
            return File(byteArray, "application/json; charset=utf-8");
        }

        public IActionResult Modifiers()
        {
            var serializedData = JsonConvert.SerializeObject(Data.Retrieve<Modifier>("DataFiles/XPModifiers.json"));
            var byteArray = Encoding.UTF8.GetBytes(serializedData);
            Response.Headers.Add(HeaderNames.ContentDisposition, serializedData);
            return File(byteArray, "application/json; charset=utf-8");
        }
    }
}