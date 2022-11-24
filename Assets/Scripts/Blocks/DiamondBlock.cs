using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondBlock : Block
{
    public override void IntroduceYourself()
    {
        base.IntroduceYourself();
        Debug.Log($"I am a Diamond Block.");
    }
}
