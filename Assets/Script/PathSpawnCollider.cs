using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSpawnCollider : MonoBehaviour {

    public float positionY = 0.81f;

    public Transform[] PathSpawnPoints;

    public GameObject Path;

    public GameObject DangerousBorder;

    void OnTriggerEnter(Collider hit)
    {
        //player has hit the collider

        if(hit.gameObject.tag == Constants.PlayerTag)
        {
            /*
            int randomSpawnPoint = Random.Range(0, PathSpawnPoints.Length);

            for (int i = 0; i < PathSpawnPoints.Length; i++)
            {
                if(i == randomSpawnPoint)
                    Instantiate(Path, PathSpawnPoints[i].position, PathSpawnPoints[i].rotation);
                else
                {
                    //instantiate the border, but rotate it 90 degrees first
                    Vector3 rotation = PathSpawnPoints[i].rotation.eulerAngles;
                    rotation.y += 90;
                    Vector3 postion = PathSpawnPoints[i].position;
                    postion.y += positionY;
                    //Instantiate(SpawnBorder, position, Quaternion.Euler(rotation));
                }
            }
            */

            Instantiate(Path, PathSpawnPoints[0].position, PathSpawnPoints[0].rotation);
        }
    }
}
