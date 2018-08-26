using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class START : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.A))
        {

            SceneManager.LoadScene("SampleScene");
            
        }
        if (Input.GetKey(KeyCode.H))
        {
            SceneManager.LoadScene("Help");
        }
        if (Input.GetKey(KeyCode.E))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
        if (Input.GetKey(KeyCode.S))
        {
            SceneManager.LoadScene("Scorelist");
        }
    }

}
