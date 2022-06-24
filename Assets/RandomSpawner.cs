using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chars.Tools;

public class RandomSpawner : MonoBehaviour
{
    public List<GameObject> prefabs;
    public bool canSpawn;
    private int spawnCount;
    private readonly LambdaTimer lambdaTimer = new LambdaTimer();
    private float radius = 4.5f;


    public void Update()
    {
        lambdaTimer.Delay(Spawn);
    }

    public void Spawn()
    {
        if (!canSpawn) return;

        int index = Mathf.Abs(Random.Range(0, prefabs.Count - 1));
        Vector3 randomPosition = Random.insideUnitCircle * radius + (Vector2)transform.position;
        Instantiate(prefabs[index], randomPosition, Quaternion.identity, null);
        spawnCount++;
    }

}
