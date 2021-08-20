using CovidApp.Models;
using CovidApp.Pages;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CovidApp.Services
{
   
    public interface ICovidInterface
    {
        [Get("/summary")]
        Task<Character> GetCharacter();
    }
}
