using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectroUser : Allogene
{

    public override string GetProperties()
    {
        var properties = 
            $"{nameof(_name)}:{"Raiden Ei"}, {nameof(_elementName)}:{_elementName}, {nameof(_baseHealth)}:{_baseHealth}, {nameof(_baseAttack)}:{_baseAttack}, {nameof(_baseEnergy)}:{60}, {nameof(_baseDefense)}:{_baseDefense}";

        return properties;
    }

    public override void AscensionStats()
    {
        Debug.Log($"HELLO my name is yae miko");
    }

}
