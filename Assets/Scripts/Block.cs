using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] protected string _name;
    [SerializeField] protected int _hitPoints;

    [SerializeField] private Color _color;

    public virutal void IntroduceYourself()
    {
        Debug.Log($"Hello I am {_name}, I have {_hitPoints} Health, With Color {_color}");
    }
}
