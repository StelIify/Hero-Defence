using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMixedWave : MonoBehaviour
{
    [SerializeField] Skeleton skelleton;
    [SerializeField] Skeleton skelletonTwo;
    bool spawn = true;
    float minFirstDelaySpawn = 20f;
    float maxFistDelaySpawn = 30f;

    float minSecondDelaySpawn = 3f;
    float maxSecondDelaySpawn = 6f;


    private IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minFirstDelaySpawn, maxFistDelaySpawn));
            SpawnSkelleton();
            yield return new WaitForSeconds(Random.Range(minSecondDelaySpawn, maxSecondDelaySpawn));
            SpawnSkelletonTwo();

        }
    }

    private void SpawnSkelleton()
    {
      var newSkeleton =  Instantiate(skelleton, transform.position, skelleton.transform.rotation);
        newSkeleton.transform.parent = transform;

    }
    private void SpawnSkelletonTwo()
    {
        var newSkeleton = Instantiate(skelletonTwo, transform.position, skelletonTwo.transform.rotation);
        newSkeleton.transform.parent = transform;
    }
}
