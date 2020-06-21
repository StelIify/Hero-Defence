using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    private void OnMouseDown()
    {
       AttempToPlaceDefenderAt(GetSquereClick());
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void AttempToPlaceDefenderAt(Vector2 gridPos)
    {
        var coinsDisplay = FindObjectOfType<CoinsDisplay>();
        int defenderCost = defender.GetGoldCost();
        if(coinsDisplay.HaveEnoughCoins(defenderCost))
        {
            SpawnDefender(gridPos);
            coinsDisplay.SpendCoins(defenderCost);
        }
    }
    private Vector2 GetSquereClick()
    {
        Vector2 mousePos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 gridPos = SnapOnGrig(worldPos);
        return gridPos;
    }

    private Vector2 SnapOnGrig(Vector2 rawGrigPos)
    {
        int posX = Mathf.RoundToInt(rawGrigPos.x);
        int poxY = Mathf.RoundToInt(rawGrigPos.y);

        return new Vector2(posX, poxY);
    }
    private void SpawnDefender(Vector2 worldPos)
    {
        var newDefender = Instantiate(defender, worldPos, transform.rotation);
    }
}
