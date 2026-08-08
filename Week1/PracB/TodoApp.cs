namespace PracB;

public class TodoApp
{
    // Stores all to-do tasks
    private readonly List<string> tasks = new List<string>();

    // Stores tag name -> task indexes
    private readonly Dictionary<string, List<int>> tags =
        new Dictionary<string, List<int>>();

    public void Run()
    {
        Console.WriteLine("Simple To-Do Manager");
        Console.WriteLine(
            "Commands: add [item], show, remove [index], clear, " +
            "tag [index] [name], get-tagged [tag], exit"
        );

        while (true)
        {
            Console.Write("\n> ");

            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error: Please enter a command.");
                continue;
            }

            // Split command and the rest of the input
            string[] parts = input.Split(
                ' ',
                2,
                StringSplitOptions.RemoveEmptyEntries
            );

            string command = parts[0].ToLower();

            string argument = "";

            if (parts.Length > 1)
            {
                argument = parts[1].Trim();
            }

            switch (command)
            {
                case "add":
                    AddTask(argument);
                    break;

                case "show":
                    ShowTasks();
                    break;

                case "remove":
                    RemoveTask(argument);
                    break;

                case "clear":
                    ClearTasks();
                    break;

                case "tag":
                    TagTask(argument);
                    break;

                case "get-tagged":
                    GetTaggedTasks(argument);
                    break;

                case "exit":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Error: Unknown command.");
                    break;
            }
        }
    }

    // Add a new task
    private void AddTask(string item)
    {
        if (string.IsNullOrWhiteSpace(item))
        {
            Console.WriteLine(
                "Error: Please enter an item to add."
            );

            return;
        }

        tasks.Add(item);

        Console.WriteLine($"Added: {item}");
    }

    // Show all tasks
    private void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine(
                "The to-do list is empty."
            );

            return;
        }

        Console.WriteLine("To-Do List:");

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine(
                $"{i + 1}. {tasks[i]}"
            );
        }
    }

    // Remove a task using its displayed index
    private void RemoveTask(string argument)
    {
        if (!int.TryParse(argument, out int index))
        {
            Console.WriteLine(
                "Error: Please enter a valid number."
            );

            return;
        }

        if (index < 1 || index > tasks.Count)
        {
            Console.WriteLine(
                "Error: Task index is out of range."
            );

            return;
        }

        int taskIndex = index - 1;

        string removedTask = tasks[taskIndex];

        tasks.RemoveAt(taskIndex);

        UpdateTagsAfterRemoval(taskIndex);

        Console.WriteLine(
            $"Removed: {removedTask}"
        );
    }

    // Update tag indexes when a task is removed
    private void UpdateTagsAfterRemoval(int removedIndex)
    {
        foreach (List<int> indexes in tags.Values)
        {
            indexes.Remove(removedIndex);

            for (int i = 0; i < indexes.Count; i++)
            {
                if (indexes[i] > removedIndex)
                {
                    indexes[i]--;
                }
            }
        }
    }

    // Clear all tasks and tags
    private void ClearTasks()
    {
        tasks.Clear();
        tags.Clear();

        Console.WriteLine(
            "All tasks have been cleared."
        );
    }

    // Add a tag to a task
    private void TagTask(string argument)
    {
        try
        {
            string[] parts = argument.Split(
                ' ',
                2,
                StringSplitOptions.RemoveEmptyEntries
            );

            if (parts.Length < 2)
            {
                throw new ArgumentException(
                    "Please use: tag [index] [name]."
                );
            }

            if (!int.TryParse(parts[0], out int index))
            {
                throw new FormatException(
                    "Please enter a valid task number."
                );
            }

            if (index < 1 || index > tasks.Count)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(index),
                    "Task index is out of range."
                );
            }

            string tagName = parts[1].Trim();

            if (string.IsNullOrWhiteSpace(tagName))
            {
                throw new ArgumentException(
                    "Tag name cannot be empty."
                );
            }

            int taskIndex = index - 1;

            if (!tags.ContainsKey(tagName))
            {
                tags[tagName] = new List<int>();
            }

            if (tags[tagName].Contains(taskIndex))
            {
                throw new InvalidOperationException(
                    "This task already has that tag."
                );
            }

            tags[tagName].Add(taskIndex);

            Console.WriteLine(
                $"Tagged task {index} with '{tagName}'."
            );
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"Error: {ex.Message}"
            );
        }
    }

    // Show tasks with a specific tag
    private void GetTaggedTasks(string tagName)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(tagName))
            {
                throw new ArgumentException(
                    "Please use: get-tagged [tag]."
                );
            }

            if (!tags.ContainsKey(tagName))
            {
                throw new KeyNotFoundException(
                    $"Tag '{tagName}' was not found."
                );
            }

            Console.WriteLine(
                $"Tasks tagged with '{tagName}':"
            );

            foreach (int taskIndex in tags[tagName])
            {
                Console.WriteLine(
                    $"{taskIndex + 1}. {tasks[taskIndex]}"
                );
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                $"Error: {ex.Message}"
            );
        }
    }
}