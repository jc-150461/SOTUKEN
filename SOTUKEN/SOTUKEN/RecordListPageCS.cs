using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SOTUKEN
{
    public class RecordListPageCS : ContentPage
    {


        public RecordListPageCS(string title)
        {
            
            //タブに表示される文字列
            Title = "記録";


            //ラベルを生成
            var label1 = new Label
            {
                FontSize = 40,
                //ビューの中央に配置
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                Text = title
            };

            Content = label1;
        }
    }
}

