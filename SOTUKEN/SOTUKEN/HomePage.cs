using Xamarin.Forms;

namespace SOTUKEN
{
    public class HomePageCS : TabbedPage
    {

        var stack = new StackLayout
        {
            Spacing = 20,
            Children = {
         new TopPageCS() {"Top"},
         new RecordListCS() { "記録"}
            }

        };
    }
}
    