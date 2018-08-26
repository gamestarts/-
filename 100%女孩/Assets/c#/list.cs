using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class list : MonoBehaviour
{
    public Text listText;


    // Use this for initialization
    void Start()
    {

        listText.text = "<color=red><size=25>历史分数：</size></color>\n" +
                "<color=yellow><size=20>" + diaoyong.vs[0] + "-------------"+diaoyong.now[0] + "\n" + diaoyong.vs[1] + "-------------" + diaoyong.now[1] + "\n" +
                diaoyong.vs[2] + "-------------" + diaoyong.now[2] + "\n" + diaoyong.vs[3] + "-------------" + diaoyong.now[3] + "\n" +
                diaoyong.vs[4] + "-------------" + diaoyong.now[4] + "\n" + diaoyong.vs[5] + "-------------" + diaoyong.now[5] + "\n" +
                diaoyong.vs[6] + "-------------" + diaoyong.now[6] + "\n" + diaoyong.vs[7] + "-------------" + diaoyong.now[7] + "\n" +
                diaoyong.vs[8] + "-------------" + diaoyong.now[8] + "\n" + diaoyong.vs[9] + "-------------" + diaoyong.now[9] + "\n</size></color>";


                
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Return))
            SceneManager.LoadScene("START");

    }
}







  

 
