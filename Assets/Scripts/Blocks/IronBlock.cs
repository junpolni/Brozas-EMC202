using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBlock : Block
{
    public override void IntroduceYourself()
    {
        base.IntroduceYourself();
        Debug.Log($"I am an Iron Block.");
    }
    
}
