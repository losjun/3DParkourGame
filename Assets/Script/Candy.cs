using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{

    public float Score = 100f;
    public float rotateSpeed = 50f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
    }

    void OnTriggerEnter(Collider col)
    {
        UIManager.Instance.IncreaseScore(Score);
        Destroy(this.gameObject);
    }
}
