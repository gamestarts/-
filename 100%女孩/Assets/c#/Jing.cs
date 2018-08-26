using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jing : MonoBehaviour {

    public float rate = 4f;
    public GameObject jing;
    private float x, y;
    // Use this for initialization
    void Start()
    {
        start();
    }

    // Update is called once per frame
    public void scjing()
    {
        x = Random.Range(3.85f, 7.7f);
        y = Random.Range(-2.3f, -4.8f);
        GameObject.Instantiate(jing, new Vector3(x, y, transform.position.z), Quaternion.identity);
    }
    public void start()
    {
        InvokeRepeating("scjing", 1, rate);
    }
}
