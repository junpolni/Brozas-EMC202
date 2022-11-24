using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydroUser : Allogene
{
    public override string GetProperties()
    {
        var properties = 
            $"{nameof(_name)}:{"Focalor"}, {nameof(_elementName)}:{_elementName}, {nameof(_baseHealth)}:{200.0f}, {nameof(_baseAttack)}:{_baseAttack}, {nameof(_baseEnergy)}:{_baseEnergy}, {nameof(_baseDefense)}:{_baseDefense}";

        return properties;
    }
}
