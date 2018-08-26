using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class role : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    public Text loseText;
    [Header("分数文字UI")]
    public Text countText;   
    public int score = 0;
    private AudioSource audioSources;
    public float timer = 1f;
    public float cdTime = 5f;
    [Header("飞行冷却时间")]
    public Text flyText;
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        loseText.text = "";
        flyText.text = "飞行冷却CD:" + cdTime.ToString();
        audioSources = GetComponent<AudioSource>();
        score += diaoyong.temp;
        setScoreText();

        
    }



// Update is called once per frame

void setScoreText()
    {
        countText.text = "目前分数:" + score.ToString();     
        //
    }

        void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        float v = Input.GetAxis("Vertical");

        rb2d.MovePosition(transform.position + new Vector3(h, v, 0) * speed * Time.deltaTime);

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            cdTime -= 1;
            timer = 1.0f;
            flyText.text = "飞行冷却CD:" + cdTime.ToString();
        }
        if (timer > 0 && cdTime > 0)
        {
            flyText.text = "飞行冷却CD:" + cdTime.ToString();
        }
        if (cdTime <= 0)
        {
            flyText.text = "飞行（F）";
        }
        if (cdTime <= 0 && Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene("flyScene");
            cdTime = 5f;
            diaoyong.temp += score;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("START");
            if (diaoyong.i < 10)
            {
                diaoyong.vs[diaoyong.i] = score;
                diaoyong.now[diaoyong.i] = System.DateTime.Now;
                diaoyong.i += 1;
            }
            else
            {
                diaoyong.i = 0;
                diaoyong.vs[diaoyong.i] = score;
                diaoyong.now[diaoyong.i] = System.DateTime.Now;
                diaoyong.i += 1;
            }
        }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Pickup"))
        {
            //... then set the other object we just collided with to inactive.
            other.gameObject.SetActive(false);
            score = score + 10;
            setScoreText();
            audioSources.Play();
           
            
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            gameObject.SetActive(false);                
            loseText.text = "游戏结束!";
            SceneManager.LoadScene("gameOver");
            if (diaoyong.i < 10)
            {
                diaoyong.vs[diaoyong.i] = score;
                diaoyong.now[diaoyong.i] = System.DateTime.Now;
                diaoyong.i += 1;
            }
            else
            {
                diaoyong.i = 0;
                diaoyong.vs[diaoyong.i] = score;
                diaoyong.now[diaoyong.i] = System.DateTime.Now;
                diaoyong.i += 1;
            }             
        }
    }
}
