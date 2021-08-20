using CovidApp.Models;
using CovidApp.Pages;
using CovidApp.Services;
using FreshMvvm;
using Newtonsoft.Json;
using Refit;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CovidApp.PageModels
{
    public class MainPageModel : FreshBasePageModel
    {

        #region 

        List<Global> globalList;
        public List<Global> GlobalList
        {
            get { return globalList; }
            set
            {
                globalList = value;
                RaisePropertyChanged();
            }
        }

        List<Country> articleList;
        public List<Country> ArticleList
        {
            get { return articleList; }
            set
            {
                articleList = value;
                RaisePropertyChanged();
            }
        }
       
        Character result;
        public Character Result
        {
            get { return result; }
            set
            {
                RaisePropertyChanged();
                 result = value;
           }
        }

        
        #endregion

        #region Metodos
        private async Task GetTaskInterf()
        {
            var WebApp = RestService.For<ICovidInterface>("https://api.covid19api.com/");
            var Result = await WebApp.GetCharacter();
            ArticleList = Result.Countries;
        }
        public override async void Init(object initData)
        {
            await GetTaskInterf();
        }

        public void FilterData()
        {
           
        }
        #endregion

        #region Command
        
        #endregion

    }


}



