using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Novice 
{
    protected float _experience;
    protected string _name;
    protected float _health;

    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? "polni" : value;
    }

    public Novice()
    {
        _experience = 0;
        _name = "";
        _health = 100.0f;
    }

    public Novice(string name = "Polni", float experience = 69, float health = 69)
    {
        _name = name;
        _experience = experience;
        _health = health;
    }

    public string GetProperties()
    {
        var properties = 
            $"{nameof(_name)}:{_name}, {nameof(_experience)}:{_experience}, {nameof(_health)}:{_health}";

        return properties;
    }
}
