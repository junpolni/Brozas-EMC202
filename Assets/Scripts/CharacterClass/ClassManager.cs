using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var novice = new Novice(name: "jun", experience: 69, health: 74);
        novice.Name = string.Empty;
        Debug.Log(novice.GetProperties());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
