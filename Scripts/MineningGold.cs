using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineningGold : MonoBehaviour
{
    [SerializeField] GameObject coinPrefab;
    int goldPerMine = 50;
    int mineningTime = 3;
    float addGoldTime = 1.5f;

    void Start()
    {
        StartCoroutine(Minening());
    }

    void Update()
    {
        
    }

    public IEnumerator Minening()
    {
        while (true)
        {
            yield return new WaitForSeconds(mineningTime);
            var coin = Instantiate(coinPrefab, transform.position, transform.rotation);
            Destroy(coin, 1.5f);
            yield return new WaitForSeconds(addGoldTime);
            FindObjectOfType<CoinsDisplay>().AddCoins(goldPerMine);
        }
       
    }
}
