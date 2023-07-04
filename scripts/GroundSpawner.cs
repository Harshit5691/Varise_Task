using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject GroundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile(bool spawnItems)
    {
        GameObject temp = Instantiate(GroundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
        if(spawnItems )
        {
            temp.GetComponent<GroundTile>().SpawnObstacle();
            temp.GetComponent<GroundTile>().SpawnCoin();

        }
    }
    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            if(i<3)
            {
                SpawnTile(false);
            }
            else
            {
                SpawnTile(true);
            }
        }
    }
}
