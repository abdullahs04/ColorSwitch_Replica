using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    string Curr;
    public SpriteRenderer sr;
    public Color Yellow; 
    public Color Blue; 
    public Color Orange; 
    public Color Red;
    public GameObject Star;
    public static int score;
    public Text txtscore;
    public static int life = 3;
    public Text txtlife;

    // Start is called before the first frame update
    void Start()
    {
        SetColor();
        score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {

        txtscore.text = "Score: " + score;
        txtlife.text = "Lives: " + life;


        if(Input.GetMouseButton(0) || Input.GetButtonDown("Jump")) 
        {
            rb.velocity = Vector2.up * 4;
        }

        if(Curr=="Yellow")
        {
            sr.color = Yellow;
        }
        else if(Curr=="Blue")
        {
            sr.color = Blue;
        }
        else if(Curr=="Orange")
        {
            sr.color = Orange;
        }
        else if(Curr=="Red")
        {
            sr.color = Red;
        }

       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.StartsWith("Win"))
        {
            SceneManager.LoadScene("YouWin");

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="ColorChanger")
        {
            SetColor();
            Destroy(collision.gameObject);
            return;
        }

        if(collision.tag=="Star")
        {

            Destroy(collision.gameObject);
            score += 10;

        }

       
        if (collision.tag != Curr && IsShapeTag(collision.tag))
        {

            life -= 1;

            if (life > 0)
            {
                RestartGame();
            }
            else 
            {
                SceneManager.LoadScene("GameOver");
            }
        }


    }

    void RestartGame()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    bool IsShapeTag(string tag)
    {
        // Add all shape-related tags here
        return tag == "Yellow" || tag == "Blue" || tag == "Orange" || tag == "Red";
    }


    void SetColor()
    {
        int index=Random.Range(0, 4);

        if(index==0)
        {
            Curr = "Yellow";
        }
        else if (index == 1)
        {
            Curr = "Blue";
        }
        else if(index == 2)
        {
            Curr = "Orange";
        }
        else if(index==3)
        {
            Curr = "Red";
        }
    }

}
