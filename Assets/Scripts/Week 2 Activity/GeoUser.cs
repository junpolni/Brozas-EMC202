using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoUser : Allogene
{
    [SerializeField] private int _geoDefense = 50;
    [SerializeField] private int _geoRes = 20;
    [SerializeField] private int _geoPotion = 30;

    public override void AllogeneStats()
    {
        base.AllogeneStats();

        Name = "Ningguang";
        ElementName = "Geo";
        MaxHealth = 100.0f;
        CurrentAtk = 50.0f;
        CurrentDef = 10 + _geoDefense;
        CurrentEnergy = 10;

        Debug.Log($"Name: {Name} | Element: {ElementName} | HP: {MaxHealth} | ATK: {CurrentAtk} | DEF: {CurrentDef} | ER: {CurrentEnergy}");
    }

    public override void FoodBuff()
    {
        base.FoodBuff();
        CurrentAtk = FoodAtkBuff + _geoPotion;
        Debug.Log($"{Name} drank Geo Potion. | +{_geoPotion} ATK |");
    }

    public override void EnemyDamage()
    {
        _enemyAtk = 150;
        Debug.Log($"{Name} has taken damage from a Geo Slime | {DamageTaken + _geoRes} HP |");
    }

    public override void CurrentStats()
    {
        base.CurrentStats();
    }
    
}
