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
    public int speed = 5;
    public string nextLevel = "Scene_1";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        string String2 = "World";
        Debug.Log(String + String2);
        Debug.Log(transform.position);
        rb = GetComponent<Rigidbody2D>();

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
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel); 
                    break;

                }



        }

    }
}



