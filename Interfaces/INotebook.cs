using System;
using System.Collections.Generic;

namespace NotebookApp
{
    public interface INotebook
    {
        void AddEntry(IEntry entry);
        void RemoveEntry(DateTime dateTime);
        IEntry GetEntry(DateTime dateTime);
        IEnumerable<IEntry> GetEntries(DateTime startDate, DateTime endDate);
        void Load(string filePath);
        void Save(string filePath);
    }
}