using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
[RequireComponent(typeof(AudioSource))]
public class role1 : MonoBehaviour
{
    public int score = 0;
    public float speed;
    private Rigidbody2D rb2d;
    [Header("分数文字UI")]
    public Text countText;

    private AudioSource audioSources;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();      
       
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
            score = score + 1;
            setScoreText();
            audioSources.Play();
           
        }
        if (other.gameObject.CompareTag("Edge"))
        {
            SceneManager.LoadScene("SampleScene");
            diaoyong.temp += score;
        }
    }
}