using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Fruit", fileName = "New Fruit", order = 0)]
public class ScriptableObject_Test : ScriptableObject
{
    public string fruitName;
    public int seedNumber;

    public override string ToString()
    {
        return "Le fruit est :" + fruitName + "avec" + seedNumber.ToString() + "pépins.";
    }
}
