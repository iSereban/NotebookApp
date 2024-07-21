using System;

namespace NotebookApp
{
    class Program
    {
        static void Main()
        {
            INotebook notebook = new Notebook();
            INotebookView view = new NotebookView();
            INotebookPresenter presenter = new NotebookPresenter(notebook, view);

            view.SetPresenter(presenter);
            view.Run();
        }
    }
}