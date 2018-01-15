using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroyManager : MonoBehaviour {

    public float destroyTime = 10f;
	// Use this for initialization
	void Start () {
		Invoke("DestroyObject", destroyTime);
	}
	
    public void DestroyObject()
    {
        //if ()
    }

}
