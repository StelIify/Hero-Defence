using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int goldCost = 50;

    public int GetGoldCost()
    {
        return goldCost;
    }
}
