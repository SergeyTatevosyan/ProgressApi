using System;
namespace ProgressApi.Models
{
    public class ValuesProgress:Progress
    {
        public ValuesProgress(int id, int value, string categoriesName, DateTime year, int maxValue):base(id,value)
        {
            CategoriesName = categoriesName;
            Year = year;
            MaxValue = maxValue;
        }

        public string CategoriesName { get; set; }
        public DateTime Year { get; set; }
        public int MaxValue { get; set; }
    }
}
