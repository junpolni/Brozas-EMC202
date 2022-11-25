using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllogenesClassManager : MonoBehaviour
{

    void Start()
    {
        var electro = new ElectroUser();
        electro.AllogeneStats();
        electro.EnemyDamage();
        electro.FoodBuff();
        electro.CurrentStats();
        
        //var geo = new GeoUser();
        /* geo.AllogeneStats();
        geo.EnemyDamage();
        geo.FoodBuff();
        geo.CurrentStats();

        var hydro = new HydroUser();
        hydro.AllogeneStats();
        hydro.FoodBuff();
        hydro.EnemyDamage();
        hydro.CurrentStats(); */
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
