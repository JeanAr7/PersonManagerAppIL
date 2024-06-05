﻿using PersonManagerApp.DataClasses;

namespace PersonManagerApp;

class PersonParser : IPersonParser
{
    public Person Parse(string csvDataLine)
    {
        var parts = csvDataLine.Split(',');
        var person = new Person
        {
            Id = int.Parse(parts[0]),
            Name = parts[1],
            Age = int.Parse(parts[2])
        };
        return person;
    }
}