using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class camera : MonoBehaviour {
 
    [Header("暂停（P）")]
    public Text pause;

    private bool paused = false;
    // Use this for initialization
    void Start () {
       
        pause.text = "暂停（P）";
    }
	
	// Update is called once per frame
	void Update () {
       
        if (Input.GetKey(KeyCode.P))
        {
            paused = true;
            pause.text = "继续（回车）";
        }
        if (Input.GetKey(KeyCode.Return))
        {
            paused = false;
            pause.text = "暂停（P）";
        }
        if (paused)
        {
            Time.timeScale = 0;
        }
        else
            Time.timeScale = 1;
    }
}
