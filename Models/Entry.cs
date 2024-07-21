using System;

namespace NotebookApp
{
    public class Entry : IEntry
    {
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        public Entry(DateTime dateTime, string description)
        {
            DateTime = dateTime;
            Description = description;
        }
    }
}