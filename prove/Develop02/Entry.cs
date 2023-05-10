using System;


class Entry
{
    public string Prompt { get; }
    public string Response { get; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
    }

    public string ToString()
    {
        return $"Prompt: {Prompt}\nResponse: {Response}";
    }
}
