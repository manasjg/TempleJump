using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    public float intensity = 10.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(Input.acceleration.x*Time.deltaTime*2.5f, 0, 0));
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform" && (collision.gameObject.transform.position.y+0.4f < transform.position.y))
        {

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, intensity));
            GetComponent<Animator>().SetTrigger("JumpTrigger");
        }
    }
}
