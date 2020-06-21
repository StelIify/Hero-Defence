using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    public void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach( var button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(90, 90, 90, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}