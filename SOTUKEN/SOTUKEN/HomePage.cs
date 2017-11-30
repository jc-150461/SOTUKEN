using Xamarin.Forms;

namespace SOTUKEN
{
    public class HomePageCS : TabbedPage
    {
        public HomePageCS
            // TabbedPageをMainPageとしてセットする
            MainPage = new TabbedPage()
            {
                Children = {
                   new TopPageCS("Top"),
                   new RecordListCS("記録"),
                   
                }
            };
        }
    }
}