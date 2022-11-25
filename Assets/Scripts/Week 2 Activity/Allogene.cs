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

    protected int _foodHealthPoints;
    protected int _foodAttackPoints;
    protected int _enemyAtk;

    public float FoodRegen => MaxHealth + (_foodHealthPoints * 2);
    public float DamageTaken => CurrentDef - _enemyAtk;
    public float FoodAtkBuff => CurrentAtk + (_foodAttackPoints * 0.5f);

    public string Name {get => _name; set => _name = string.IsNullOrEmpty(value) ? "yae miko" : value; }
    public string ElementName {get => _elementName; set => _elementName = string.IsNullOrEmpty(value) ? "electro" : value; }
    public float MaxHealth { get => _baseHealth; set => _baseHealth = value; }
    public float CurrentAtk { get => _baseAttack; set => _baseAttack = value; }
    public int CurrentDef { get => _baseDefense; set => _baseDefense = value; }
    public int CurrentEnergy { get => _baseEnergy; set => _baseEnergy = value; }

    public Allogene()
    {
        _name = "";
        _elementName = "";
        _baseHealth = 100.0f;
        _baseAttack = 10.0f;
        _baseEnergy = 10;
        _baseDefense = 10;
    }

    public virtual void AllogeneStats()
    {
        _name = Name;
        _elementName = ElementName;
        _baseHealth = MaxHealth;
        _baseAttack = CurrentAtk;
        _baseEnergy = CurrentDef;
        _baseDefense = CurrentDef;

    }
    
    /*public Allogene(string name, string elementName, float baseHealth, float baseAttack, int baseEnergy, int baseDefense)
    {
        _name = name;
        _elementName = elementName;
        _baseHealth = baseHealth;
        _baseAttack = baseAttack;
        _baseEnergy = baseEnergy;
        _baseDefense = baseDefense;
    } */

    public virtual void EnemyDamage() // damage taken from enemy
    {
        _enemyAtk = 50;
        Debug.Log($"{Name} has taken damage from a Slime | -{_enemyAtk} HP |");
    }

    public virtual void FoodBuff() // health and atk buff 
    {
        _foodHealthPoints = 10;
        _foodAttackPoints = 20;

        Debug.Log($"{Name} ate Sweet Madame. | +{_foodHealthPoints} HP |");
        Debug.Log($"{Name} ate Adeptus' Temptation. | +{_foodAttackPoints} ATK |");
    }

    public virtual void CurrentStats() // shows current stats
    {
        CurrentAtk = FoodAtkBuff;
        MaxHealth = DamageTaken + FoodRegen;
        Debug.Log($"Name: {Name} | Element: {ElementName} | HP: {MaxHealth} | ATK: {CurrentAtk} | DEF: {CurrentDef} | ER: {CurrentEnergy}");
    }
    
}
