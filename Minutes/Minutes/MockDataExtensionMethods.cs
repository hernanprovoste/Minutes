using System;
using System.Collections.Generic;
using System.Text;

namespace Minutes
{
    public static class MockDataExtensionMethods
    {
        public static void LoadMockData(this IEntryStore store)
        {
            var a = new Entry() { Title = "Sprint Planning Meeting", Content = "1, Scope" };
            var b = new Entry() { Title = "Go to Gym", Content = "1, Scope" };
            var c = new Entry() { Title = "Go to Eat", Content = "1, Scope" };

            store.WriteAsync(a).Wait();
            store.WriteAsync(b).Wait();
            store.WriteAsync(c).Wait();
        }
    }
}
