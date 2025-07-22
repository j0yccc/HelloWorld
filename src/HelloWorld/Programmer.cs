using System;
using System.Collections.Generic;

public class Programmer {
    public List<string> Languages = new List<string>();
    public void AddLanguage(string language)
    {
        Languages.Add(language);
    }
}

public class ProgrammerTeacher : Programmer { 
    public bool Teach(Programmer programmer, string language)
    {
        if (Languages.Contains(language))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}