using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyBk : MonoBehaviour
{

    // Use this for initialization
    public float speed = 10f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

    }
}
