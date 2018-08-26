using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starmove : MonoBehaviour {
    public float speed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if(transform.position.x<-8f)
        {
            Destroy(this.gameObject);
        }
	}
}
