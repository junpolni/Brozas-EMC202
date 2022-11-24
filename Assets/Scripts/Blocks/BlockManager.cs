using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public Block[] Blocks;

    private void Start()
    {
        foreach (var block in Blocks)
        {
            block.IntroduceYourself();
        }
    }
}
