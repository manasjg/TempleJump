using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {
    Vector2 pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pos = transform.position;
        Vector3 position = new Vector3(Random.Range(-1.22f, 1.22f), 3f);
        pos.y -= 1f*Time.deltaTime;
        transform.position = pos;
        if (transform.position.y < -3f)
        {
            transform.position = position;

        }
    }
}
