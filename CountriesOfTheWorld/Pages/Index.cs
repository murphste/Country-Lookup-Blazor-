using System;
using CountriesOfTheWorld.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Web;
using System.Text.Json;
using System.Net.Http.Json;
using System.Text.RegularExpressions;

namespace CountriesOfTheWorld.Pages
{
    public partial class Index : ComponentBase
    {

        private List<CountryData>? data;
        //private List<CountryData>? result;
        private string errorMsg;
        private bool found;

        //private string inputCountry;


        [Parameter]
        public string SearchTerm { get; set; }




        // Tried to enfoce validation here for only alphabetic characters on the setting of Search Term but kept causing an unhandled out of memory exception
        // Give it a go yourself and see

        /*Regex pattern = new Regex(@"^[A-Za-z]*$");

        [Parameter]
        public string SearchTerm
        {
            get
            {
                return SearchTerm;
            }
            set
            {
                *//*string pattern = "^[A-Za-z]*$";*//*
                
                if (pattern.IsMatch(SearchTerm))
                {
                    SearchTerm = value;
                }
                else
                {
                    throw new ArgumentException("Search term is invalid");
                }
            }
        }*/


        private async Task GetQueryDataAsync()
        {
            try
            {
                string queryUri = "https://restcountries.eu/rest/v2/name/" + SearchTerm + "?fullText=true";
                string europeUri = "https://restcountries.eu/rest/v2/region/europe";


                // Logic to handle a search query
                if (string.IsNullOrWhiteSpace(SearchTerm))
                {
                    data = await Http.GetFromJsonAsync<List<CountryData>>(europeUri);
                }
                else
                {
                    data = await Http.GetFromJsonAsync<List<CountryData>>(queryUri);
                }

                errorMsg = String.Empty;
                found = true;
            }
            catch (Exception e)
            {
                found = false;
                errorMsg = e.Message;
            }
        }



        List<CountryData> FilteredCountries => data.Where(i => i.name.ToLower().Contains(SearchTerm.ToLower())).ToList();

        public List<CountryData> CountryLookup()
        {
            return FilteredCountries;
        }

        protected override async Task OnInitializedAsync()
        {
            await GetQueryDataAsync();
        }
    }
}
