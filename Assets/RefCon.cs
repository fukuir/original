using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefCon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right*10);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
