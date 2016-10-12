using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIBasicStudyProgram.DataModel
{
   public class MyItems
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }

    public class ItemsManager
    {
        public static void GetItems(string category,ObservableCollection<MyItems> items)
        {
            var list = getMyItems();
            var filterItems = list.Where(p => p.Category == category).ToList();
            items.Clear();
            filterItems.ForEach(p => items.Add(p));
        }
        public static List<MyItems> getMyItems()
        {
            var items = new List<MyItems>();
            items.Add(new MyItems() { Id = 1, Category = "Second", Headline = "One", Subhead = "one", DateLine = "hello", Image = "/Assets/Second1.png" });
            items.Add(new MyItems() { Id = 2, Category = "Second", Headline = "Etiam ac felis viverra", Subhead = "vulputate nisl ac, aliquet nisi", DateLine = "tortor porttitor, eu fermentum ante congue", Image = "/Assets/Second2.png" });
            items.Add(new MyItems() { Id = 3, Category = "Second", Headline = "Integer sed turpis erat", Subhead = "Sed quis hendrerit lorem, quis interdum dolor", DateLine = "in viverra metus facilisis sed", Image = "/Assets/Second3.png" });
            items.Add(new MyItems() { Id = 4, Category = "Second", Headline = "Proin sem neque", Subhead = "aliquet quis ipsum tincidunt", DateLine = "Integer eleifend", Image = "/Assets/Second4.png" });
            items.Add(new MyItems() { Id = 5, Category = "Second", Headline = "Mauris bibendum non leo vitae tempor", Subhead = "In nisl tortor, eleifend sed ipsum eget", DateLine = "Curabitur dictum augue vitae elementum ultrices", Image = "/Assets/Second5.png" });

            items.Add(new MyItems() { Id = 6, Category = "First", Headline = "Lorem ipsum", Subhead = "dolor sit amet", DateLine = "Nunc tristique nec", Image = "/Assets/First1.png" });
            items.Add(new MyItems() { Id = 7, Category = "First", Headline = "Etiam ac felis viverra", Subhead = "vulputate nisl ac, aliquet nisi", DateLine = "tortor porttitor, eu fermentum ante congue", Image = "/Assets/First2.png" });
            items.Add(new MyItems() { Id = 8, Category = "First", Headline = "Integer sed turpis erat", Subhead = "Sed quis hendrerit lorem, quis interdum dolor", DateLine = "in viverra metus facilisis sed", Image = "/Assets/First3.png" });
            items.Add(new MyItems() { Id = 9, Category = "First", Headline = "Proin sem neque", Subhead = "aliquet quis ipsum tincidunt", DateLine = "Integer eleifend", Image = "/Assets/First4.png" });
            items.Add(new MyItems() { Id = 10, Category = "First", Headline = "Mauris bibendum non leo vitae tempor", Subhead = "In nisl tortor, eleifend sed ipsum eget", DateLine = "Curabitur dictum augue vitae elementum ultrices", Image = "/Assets/First5.png" });
            return items;
        }
    }
}
