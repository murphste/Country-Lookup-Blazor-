// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CountriesOfTheWorld.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\_Imports.razor"
using CountriesOfTheWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\_Imports.razor"
using CountriesOfTheWorld.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 157 "C:\Users\Stephen's Laptop\Documents\College Files\Year 4\Semester 7\EAD - Enterprise App Development 1\CA3\Local Repo\ead_ca3\CountriesOfTheWorld\Pages\Index.razor"
       



// Need instance of Root as data (response obj) needs to contain an IEnumerable to iterate over
// Set this up to contain objects of the model class CountryData as below
      public class Root
      {
      public List<CountryData> CountryData { get; set; }
      }

       

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
