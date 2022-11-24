using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllogenesClassManager : MonoBehaviour
{

    void Start()
    {
        var electro = new ElectroUser();
        Debug.Log(electro.GetProperties());
        electro.AscensionStats();
        

        var geo = new GeoUser();
        Debug.Log(geo.GetProperties());

        var hydro = new HydroUser();
        Debug.Log(hydro.GetProperties());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
