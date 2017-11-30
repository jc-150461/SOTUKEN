using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SOTUKEN
{
    public class HomePageCS : TabbedPage
    {

        public HomePageCS()
        {
            Children.Add(new TopPageCS());
            Children.Add(new RecordListCS());
            Children.Add(new StopWatchPageCS());
        }
    }
}
