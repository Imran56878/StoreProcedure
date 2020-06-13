using Humanizer;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileReadingTest
{
  public  class HumanizeDemo
    {
        public void HumanizeProperty()
        {
            Console.WriteLine(DateTime.UtcNow.AddHours(-30).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(30).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(2).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddDays(564).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddDays(-564).Humanize());

            Console.WriteLine("Long text to truncate ".Truncate(10,"..."));

            Console.WriteLine(1.ToWords());
            Console.WriteLine(10.ToWords());
            Console.WriteLine(1465464658.ToWords());

            Console.WriteLine(1.ToOrdinalWords());
            Console.WriteLine(10.ToOrdinalWords());
            Console.WriteLine(1465464658.ToOrdinalWords());

            Console.WriteLine("Man".Pluralize());
            Console.WriteLine("Wife".Pluralize());
            Console.WriteLine("Men".Pluralize());
            Console.WriteLine("Vehicles".Singularize());

            Console.WriteLine("Sentence casing".Transform(To.LowerCase));
            Console.WriteLine("Sentence casing".Transform(To.SentenceCase));
            Console.WriteLine("Sentence casing".Transform(To.TitleCase));
            Console.WriteLine("Sentence casing".Transform(To.UpperCase));
            Console.WriteLine("Pascal case input string is turned into sentence".Dehumanize());
            Console.WriteLine("Pascal case input string is turned into sentence".Kebaberize());
        }
    }
}
