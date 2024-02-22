using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSO", menuName = "Scriptable Object/Mi Scriptable", order = 0)]
public class SO101 : ScriptableObject
{
    public string fruitName;
    public int price;
    public Sprite sprite;
    public bool inStock;
}
