using System.Collections.ObjectModel;
using Brainvita.Model;

namespace Brainvita.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<DemoItem> FirstCollection { get; set; }

        public ObservableCollection<DemoItem> SecondCollection { get; set; }

        public MainViewModel()
        {
            FirstCollection = new ObservableCollection<DemoItem>
            {
                new DemoItem{ Title = "(A)臺灣二二八事件", Subtitle = "二二八事件是台灣於1947年2月底發生的大規模民眾反抗政府事件"},
                new DemoItem{ Title = "(B)政府遷臺", Subtitle = "於1949年12月27日成都撤守後，政府播遷台北，開啟了國共日後台海兩岸對峙的局面。"},
                new DemoItem{ Title = "(C)臺灣光復", Subtitle = "臺灣光復是指第二次世界大戰結束後的1945年10月25日，中國國民政府對其從大日本帝國接手統治臺灣的歷史事件的稱呼"},
                new DemoItem{ Title = "(D)韓戰爆發", Subtitle = "北韓在蘇聯和中國的支持下，在1950年6月25日入侵南韓"},
            };

            SecondCollection = new ObservableCollection<DemoItem>();
        }

        /// <summary>
        /// Switches the item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void SwitchItem(DemoItem item)
        {
            if (FirstCollection.Contains(item))
            {
                FirstCollection.Remove(item);
                SecondCollection.Add(item);
            }
            else
            {
                SecondCollection.Remove(item);
                FirstCollection.Add(item);
            }
        }
    }
}
