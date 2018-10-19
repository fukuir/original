using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCon : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 100);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
