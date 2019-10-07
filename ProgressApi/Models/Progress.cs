using System;
namespace ProgressApi.Models
{
    public class Progress
    {
        public Progress(int id, int value)
        {
            Id = id;
            Value = value;
        }

        public int Id { get; set; }
        public int Value { get; set; }
    }
}
