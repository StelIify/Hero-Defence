using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkelletonSpawner : MonoBehaviour
{
    [SerializeField] Skeleton skelleton;
    bool spawn = true;
    float minDelaySpawn = 8f;
    float maxDelaySpawn = 30f;

    private IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minDelaySpawn, maxDelaySpawn));
            SpawnSkelleton();

        }
    }

    private void SpawnSkelleton()
    {
        Skeleton newSkelleton = Instantiate(skelleton, transform.position, skelleton.transform.rotation) as Skeleton;
        newSkelleton.transform.parent = transform;

    }
}
