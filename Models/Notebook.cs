using System;
using System.Collections.Generic;
using System.Linq;

namespace NotebookApp
{
    public class Notebook : INotebook
    {
        private readonly List<IEntry> entries;

        public Notebook()
        {
            entries = new List<IEntry>();
        }

        public void AddEntry(IEntry entry)
        {
            entries.Add(entry);
        }

        public void RemoveEntry(DateTime dateTime)
        {
            entries.RemoveAll(e => e.DateTime == dateTime);
        }

        public IEntry GetEntry(DateTime dateTime)
        {
            return entries.FirstOrDefault(e => e.DateTime == dateTime);
        }

        public IEnumerable<IEntry> GetEntries(DateTime startDate, DateTime endDate)
        {
            return entries.Where(e => e.DateTime >= startDate && e.DateTime <= endDate);
        }

        public void Load(string filePath)
        {
            // Логика загрузки из файла
        }

        public void Save(string filePath)
        {
            // Логика сохранения в файл
        }
    }
}