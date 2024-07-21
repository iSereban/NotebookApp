using System;

namespace NotebookApp
{
    public interface INotebookPresenter
    {
        void AddEntry(string description, DateTime dateTime);
        void RemoveEntry(DateTime dateTime);
        void ShowEntries(DateTime startDate, DateTime endDate);
        void LoadEntries(string filePath);
        void SaveEntries(string filePath);
    }
}