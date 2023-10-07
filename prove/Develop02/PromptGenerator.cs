public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public string _promptFilePath;
    public string GetRandomPrompt()
    {

        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count());
        return _prompts[randomNumber];
    }

    public void LoadPromptsFromFile()
    {
        string[] prompts = System.IO.File.ReadAllLines(_promptFilePath);//read prompts from file
        foreach (string p in prompts)
        {
            _prompts.Add(p);
        }
    }
    public void AddPrompt(string newPromptText)
    {
        using (StreamWriter file = File.AppendText(_promptFilePath))
        {
            file.WriteLine(newPromptText);
        }
        _prompts.Add(newPromptText);
        Console.WriteLine("New prompt added!\n");
    }
}