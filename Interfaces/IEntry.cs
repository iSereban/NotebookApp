using System;

namespace NotebookApp
{
    public interface IEntry
    {
        DateTime DateTime { get; set; }
        string Description { get; set; }
    }
}