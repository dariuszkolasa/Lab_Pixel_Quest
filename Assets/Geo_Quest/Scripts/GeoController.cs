using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    string String = "Hello ";
    int Number = 3;
    private Rigidbody2D rb;
    public SpriteRenderer spr;
    public int speed = 5;
    public string level2 = "Scene 2";
    public string level3 = "Scene 3";
    public string level4 = "Scene 4";
    public string level5 = "Scene 5";
    public string level6 = "Scene 6";
    public string level7 = "Scene 7";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string String2 = "World";
        Debug.Log(String + String2);
        Debug.Log(transform.position);
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Number);
        //Number++;
        //transform.position += new Vector3(0.005f, 0, 0);
        // if (Input.GetKeyUp(KeyCode.W))
        // {
        //    transform.position += new Vector3(0, 1, 0);
        // }
        // if (Input.GetKeyUp(KeyCode.A))
        // {
        //     transform.position += new Vector3(-1, 0, 0);
        //}
        // if (Input.GetKeyUp(KeyCode.S))
        // {
        //     transform.position += new Vector3(0, -1, 0);
        // }
        // if (Input.GetKeyUp(KeyCode.D))
        // {
        //    transform.position += new Vector3(1, 0, 0);
        // }
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    rb.velocity = new Vector2(-1,rb.velocity.y);
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    rb.velocity = new Vector2(1,rb.velocity.y);
        //}
        float xInput = Input.GetAxis("Horizontal");
        //Debug.Log(xInput);
        rb.velocity = new Vector3(xInput * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            spr.color = Color.yellow;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            spr.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) 
        {
            spr.color = Color.blue;
        }





    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    Debug.Log("Player Has Died");
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish 1":
                {
                    SceneManager.LoadScene(level2); 
                    break;

                }
            case "Finish 2":
                {
                    SceneManager.LoadScene(level3);
                    break;
                }
            case "Finish 3":
                {
                    SceneManager.LoadScene(level4);
                    break;
                }
            case "Finish 4":
                {
                    SceneManager.LoadScene(level5);
                    break;
                }
            case "Finish 5":
                {
                    SceneManager.LoadScene(level6);
                    break;

                }
            case "Finish 6":
                {
                    SceneManager.LoadScene(level7);
                    break;
                }




        }

    }
}



