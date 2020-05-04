using System;

namespace ProAgil.WebApi.Model
{
    public class Event
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime DateEvent { get; set; }
        public string Theme { get; set; }
        public int TotalPeople { get; set; }
        public string Lot { get; set; }
        public string ImageURL { get; set; }
    }
}