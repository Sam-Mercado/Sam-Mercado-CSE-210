
using System;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    //List to store multiple journal entries
    public List<Entry> _entries = new List<Entry>();
    //Method/function to create a new journal entry, populate it, and add the list 
    public void NewEntry()
    {
        Entry userEntry = new Entry();//Create a new entry object 
        userEntry.GenerateDate(); //Generate the date for the entry
        userEntry.ListGeneration(); //Genrate a random prompt
        userEntry.ResponceGeneration(); //Get user'd response
        _entries.Add(userEntry); //Add the compleated entry to the list
    }

    //Method to display all entries in the console
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)//Iterate over all entries
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._response}");
            Console.WriteLine(); //Output a blank line fo better readability
        }
    }


    //Loads entries from  specific file, supports plain text and CSV formats
    public void LoadEntries(string filename)
    {
        if (filename.EndsWith(".csv")) //Check if the filename ends with .csv
        {
            string[] lines = System.IO.File.ReadAllLines(filename);//Read all lines from the file  
            foreach (string line in lines)
            {
                string[] parts = line.Split(","); // Split each line by comma

                Entry loadedEntry = new Entry
                {
                    _date = parts[0],
                    _prompt = parts[1],
                    _response = parts[2]
                };
                _entries.Add(loadedEntry); //Add the entry to the list 

                //Console.WriteLine($"Date: {date}");
                //Console.WriteLine($"Prompt: {prompt}");
                //Console.WriteLine($"{response}");
                //Console.WriteLine();
            }
        }
        else
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string journalEntries = reader.ReadToEnd();//read the entire file content
                Console.Write(journalEntries);//Output the content to the console
            }
        }
    }

    //Save all entries to a specific files
    public void SaveEntries(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            if (filename.EndsWith(".csv"))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
                }
            }
            else
            {
                foreach (Entry entry in _entries)
                {

                    outputFile.WriteLine($"Date:{entry._date},{entry._prompt},{entry._response}");
                    outputFile.WriteLine($"Prompt:{entry._prompt}");
                    outputFile.WriteLine($"{entry._response}");
                    outputFile.WriteLine();
                }
            }
        }
    }
}