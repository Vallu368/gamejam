using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollAgain : MonoBehaviour
{
    [SerializeField] GameObject Dice;
    public void MoveDice()
    {
        Dice.transform.position = new Vector2(0, 0);
    }
}
