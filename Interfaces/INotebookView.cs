using System.Collections.Generic;

namespace NotebookApp
{
    public interface INotebookView
    {
        void SetPresenter(INotebookPresenter presenter);
        void DisplayEntries(IEnumerable<IEntry> entries);
        void DisplayMessage(string message);
        string GetUserInput(string prompt);
        void Run();
    }
}