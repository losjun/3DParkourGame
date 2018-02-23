using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreater : MonoBehaviour {

    public Transform[] StuffSpawnPoints;

    public GameObject[] Bonus;

    public GameObject[] Obstacles;


    public bool RandomX = false;
    public float minX = -2f, maxX = 2f;



    void CreateObject(Vector3 position, GameObject prefab)
    {
        if (RandomX)
        {
            position += new Vector3(Random.Range(minX, maxX), 0, 0);
        }
        Instantiate(prefab, position, Quaternion.identity);

    }


	// Use this for initialization
	void Start () {

        bool placeObsTacle = Random.Range(0, 2) == 0;
        int obstacleIndex = -1;
        if (placeObsTacle)
        {
            obstacleIndex = Random.Range(1, StuffSpawnPoints.Length);

            CreateObject(StuffSpawnPoints[obstacleIndex].position, Obstacles[Random.Range(0, Obstacles.Length)]);
        }

        for (int i = 0; i < StuffSpawnPoints.Length; i++)
        {
            if (i == obstacleIndex) continue;
            if (Random.Range(0, 3) == 0)
            {
                CreateObject(StuffSpawnPoints[i].position, Bonus[Random.Range(0, Bonus.Length)]);
            }
        }
	}
	
}
