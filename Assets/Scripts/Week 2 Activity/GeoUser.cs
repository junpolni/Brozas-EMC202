using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoUser : Allogene
{
    public override string GetProperties()
    {
        var properties = 
            $"{nameof(_name)}:{"Zhongli"}, {nameof(_elementName)}:{_elementName}, {nameof(_baseHealth)}:{_baseHealth}, {nameof(_baseAttack)}:{_baseAttack}, {nameof(_baseEnergy)}:{_baseEnergy}, {nameof(_baseDefense)}:{50}";

        return properties;
    }
}
