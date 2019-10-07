using System;
namespace ProgressApi.Models
{
    public class PercentProgress : Progress
    {
        public PercentProgress(int id, int value, string categoriesName, DateTime year) :base(id,value)
        {
            CategoriesName = categoriesName;
            Year = year;
        }

        public string CategoriesName { get; set; }
        public DateTime Year { get; set; }


    }
}
