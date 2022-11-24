using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;

namespace OpenSilverRadComboboxVirtualization
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Enter construction logic here...
            var languages = new List<Language>
            {
                new Language { ID = 1, DisplayName = "English" },
                new Language { ID = 2, DisplayName = "French" },
            };

            for (var i = 0; i < 1; i++)
            {
                languages.Add(new Language
                {
                    ID = i + 2,
                    DisplayName = "Language" + i
                });
            }
            this.Rcb.ItemsSource = languages;
        }
    }

    public class Language
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
    }
}
