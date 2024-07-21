using System;

namespace NotebookApp
{
    public class NotebookPresenter : INotebookPresenter
    {
        private readonly INotebook notebook;
        private readonly INotebookView view;

        public NotebookPresenter(INotebook notebook, INotebookView view)
        {
            this.notebook = notebook;
            this.view = view;
        }

        public void AddEntry(string description, DateTime dateTime)
        {
            var entry = new Entry(dateTime, description);
            notebook.AddEntry(entry);
            view.DisplayMessage("Запись добавлена.");
        }

        public void RemoveEntry(DateTime dateTime)
        {
            notebook.RemoveEntry(dateTime);
            view.DisplayMessage("Запись удалена.");
        }

        public void ShowEntries(DateTime startDate, DateTime endDate)
        {
            var entries = notebook.GetEntries(startDate, endDate);
            view.DisplayEntries(entries);
        }

        public void LoadEntries(string filePath)
        {
            notebook.Load(filePath);
            view.DisplayMessage("Записи загружены.");
        }

        public void SaveEntries(string filePath)
        {
            notebook.Save(filePath);
            view.DisplayMessage("Записи сохранены.");
        }
    }
}