using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SOTUKEN
{
    public partial class App : Application
    {
        public App()
        {

            MainPage = new TopPageCS()
            {
                Children = {
                   new TopPageCS("Top"),
                   new RecordListPageCS("記録")
                }
            };
        }
    }
}
