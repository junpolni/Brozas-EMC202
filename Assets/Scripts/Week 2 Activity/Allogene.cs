using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Allogene 
{
    protected string _name;
    protected string _elementName;
    protected float _baseHealth;
    protected int _baseEnergy;
    protected int _baseDefense;
    protected float _baseAttack;

    protected float _addnlHealth;
    protected float _addnlAttack;
    protected int _addnlDefense;
    protected int  _addnlEnergy;

    public float MaxHealth => _baseHealth + (_addnlHealth * 2);

    public float CurrentAtk => _baseAttack + _addnlAttack;

    public int CurrentDef => _baseDefense + _addnlDefense;

    public int CurrentEnergy => _baseEnergy + _addnlEnergy;

    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? "Yae Miko" : value;
    }

    public Allogene()
    {
        _name = "";
        _elementName = "";
        _baseHealth = 100.0f;
        _baseAttack = 10.0f;
        _baseEnergy = 10;
        _baseDefense = 10;
    }

    public Allogene(string name, string elementName, float baseHealth, float baseAttack, int baseEnergy, int baseDefense)
    {
        _name = name;
        _elementName = elementName;
        _baseHealth = baseHealth;
        _baseAttack = baseAttack;
        _baseEnergy = baseEnergy;
        _baseDefense = baseDefense;
    }

    public virtual string GetProperties()
    {
        var properties = 
            $"{nameof(_name)}:{_name}, {nameof(_elementName)}:{_elementName}, {nameof(_baseHealth)}:{_baseHealth}, {nameof(_baseAttack)}:{_baseAttack}, {nameof(_baseEnergy)}:{_baseEnergy}, {nameof(_baseDefense)}:{_baseDefense}";

        return properties;
    }

    public virtual void AscensionStats()
    {
        Debug.Log($"HELLO");
    }

    public virtual void FoodBuff()
    {

    }
    
}
