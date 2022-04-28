using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Doodle : MonoBehaviour
{
    public TextMeshProUGUI ScoreTxt;
    private int score;
    public static Doodle instance;
    float horizontal;
    public Rigidbody2D DoodleRigid;
    public GameObject RestartPanel;
    void Start()
    {
        RestartPanel.SetActive(false);
        if (instance == null)                             
        {
            instance = this;
        }
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)    
        {
            horizontal = Input.acceleration.x;                  
        }

        if (Input.acceleration.x < 0)                           
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;    
        }

        if (Input.acceleration.x > 0)                          
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;     
        }

        DoodleRigid.velocity = new Vector2(Input.acceleration.x * 10f, DoodleRigid.velocity.y);
        
        ScoreTxt.text = "Score: " + score;
        if(score < Mathf.CeilToInt(DoodleRigid.position.y * 100))
            score = Mathf.CeilToInt(DoodleRigid.position.y * 100);
    }
    public void OnCollisionEnter2D(Collision2D collision)       
    {
        if (collision.collider.name == "DeadZone")             
        {
            RestartPanel.SetActive(true);
            Destroy(gameObject);
        }
    }

}
