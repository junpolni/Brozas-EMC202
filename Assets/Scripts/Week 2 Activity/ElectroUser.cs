using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroUser : Allogene
{

    [SerializeField] private int _electroEnergy = 50;
    [SerializeField] private int _electroRes = 20;
    [SerializeField] private int _electroPotion = 30;

    public override void AllogeneStats()
    {
        base.AllogeneStats();

        Name = "Yae Miko";
        ElementName = "Electro";
        MaxHealth = 100.0f;
        CurrentAtk = 50.0f;
        CurrentDef = 10;
        CurrentEnergy = 10 + _electroEnergy;

        Debug.Log($"Name: {Name} | Element: {ElementName} | HP: {MaxHealth} | ATK: {CurrentAtk} | DEF: {CurrentDef} | ER: {CurrentEnergy}");
    }

    public override void FoodBuff()
    {
        base.FoodBuff();
        CurrentAtk = FoodAtkBuff + _electroPotion;
        Debug.Log($"{Name} drank Electro Potion. | +{_electroPotion} ATK |");
    }

    public override void EnemyDamage()
    {
        CurrentDef = 10 + _electroRes;
        _enemyAtk = 80;
        Debug.Log($"{Name} has taken damage from an Electro Slime | {DamageTaken} HP |");
    }

    public override void CurrentStats()
    {
        base.CurrentStats();
    }
}
