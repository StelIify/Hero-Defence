using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderShooter : MonoBehaviour
{
    [SerializeField] GameObject arrow, bow;

    private void Start()
    {
        SetLaneSpawner();
    }
    private void Update()
    {
        
    }

    private void SetLaneSpawner()
    {
        SkelletonSpawner[] spawners = FindObjectsOfType<SkelletonSpawner>();
        SpawnMixedWave [] mixedSpawner = FindObjectsOfType<SpawnMixedWave>();

        foreach ( var spawner in spawners)
        {

        }
    }
    public void Fire()
    {
        Instantiate(arrow, bow.transform.position, transform.rotation);
    }
}
