using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydroUser : Allogene
{
    [SerializeField] private float _hydroHealth = 100.0f;
    [SerializeField] private int _hydroRes = 20;
    [SerializeField] private int _hydroPotion = 30;

    public override void AllogeneStats()
    {
        base.AllogeneStats();

        Name = "Kokomi";
        ElementName = "Hydro";
        MaxHealth = 100.0f + _hydroHealth;
        CurrentAtk = 50.0f;
        CurrentDef = 10;
        CurrentEnergy = 10;

        Debug.Log($"Name: {Name} | Element: {ElementName} | HP: {MaxHealth} | ATK: {CurrentAtk} | DEF: {CurrentDef} | ER: {CurrentEnergy}");
    }

    public override void FoodBuff()
    {
        base.FoodBuff();
        CurrentAtk = FoodAtkBuff + _hydroPotion;
        Debug.Log($"{Name} drank Hydro Potion. | +{_hydroPotion} ATK |");
    }

    public override void EnemyDamage()
    {
        CurrentDef = 10 + _hydroRes;
        _enemyAtk = 60;
        Debug.Log($"{Name} has taken damage from a Hydro Slime | {DamageTaken} HP |");
    }

    public override void CurrentStats()
    {
        base.CurrentStats();
    }
}
