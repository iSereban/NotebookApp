using System;
using System.Collections.Generic;

namespace NotebookApp
{
    public class NotebookView : INotebookView
    {
        private INotebookPresenter presenter;

        public void SetPresenter(INotebookPresenter presenter)
        {
            this.presenter = presenter;
        }

        public void DisplayEntries(IEnumerable<IEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"{entry.DateTime}: {entry.Description}");
            }
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public void Run()
        {
            while (true)
            {
                DisplayMenu();
                var command = GetUserInput("Введите команду:").ToLower();

                switch (command)
                {
                    case "add":
                        var description = GetUserInput("Введите описание:");
                        var dateTime = DateTime.Parse(GetUserInput("Введите дату и время (yyyy-MM-dd HH:mm):"));
                        presenter.AddEntry(description, dateTime);
                        break;
                    case "remove":
                        dateTime = DateTime.Parse(GetUserInput("Введите дату и время записи для удаления (yyyy-MM-dd HH:mm):"));
                        presenter.RemoveEntry(dateTime);
                        break;
                    case "show":
                        var startDate = DateTime.Parse(GetUserInput("Введите начальную дату (yyyy-MM-dd):"));
                        var endDate = DateTime.Parse(GetUserInput("Введите конечную дату (yyyy-MM-dd):"));
                        presenter.ShowEntries(startDate, endDate);
                        break;
                    case "load":
                        var filePath = GetUserInput("Введите путь к файлу:");
                        presenter.LoadEntries(filePath);
                        break;
                    case "save":
                        filePath = GetUserInput("Введите путь к файлу:");
                        presenter.SaveEntries(filePath);
                        break;
                    case "exit":
                        return;
                    default:
                        DisplayMessage("Неизвестная команда.");
                        break;
                }
            }
        }

        private void DisplayMenu()
        {
            Console.WriteLine("Команды:");
            Console.WriteLine("add - Добавить новую запись");
            Console.WriteLine("remove - Удалить запись");
            Console.WriteLine("show - Показать записи за определённый период");
            Console.WriteLine("load - Загрузить записи из файла");
            Console.WriteLine("save - Сохранить записи в файл");
            Console.WriteLine("exit - Выйти из приложения");
        }
    }
}