using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class star : MonoBehaviour {
    public float rate = 1f;
    public float speed = 10f;
    public GameObject Xing;
    private float x, y;
	// Use this for initialization
	void Start () {
        start();
	}
	
	// Update is called once per frame
	public void scXing()
    {
        x = Random.Range(3.85f, 7.7f);
        y = Random.Range(-2.3f, -4.8f);
        GameObject.Instantiate(Xing, new Vector3(x,y,transform.position.z), Quaternion.identity);
    }
    public void start()
    {
        InvokeRepeating("scXing", 1, rate);
    }
}
