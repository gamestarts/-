using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 背景 : MonoBehaviour {

    // Use this for initialization
    public float speed = 2f;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        //判断
        if (transform.position.x < -15.95f)
        {
            transform.position = new Vector3(transform.position.x + 2*15.95f, transform.position.y, transform.position.z);
        }
    }
}
