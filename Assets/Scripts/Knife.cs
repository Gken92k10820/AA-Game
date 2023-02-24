using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    bool isTouch = false;
    [SerializeField] float speed = 10f;

    Rigidbody2D myBody;
    GameController gc;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        gc = FindObjectOfType<GameController>();
    }
    void LateUpdate()
    {
        if (!isTouch)
        {
            myBody.MovePosition(myBody.position + Vector2.up * speed * Time.deltaTime);
            //transform.Translate(0f, 0.1f, 0f);
        }
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Rotator")
        {
            transform.SetParent(collision.transform);
            isTouch = true;
        }
        else if (collision.tag == "Knife")
        {
            gc.LoadGameOver();
        }    
    }
}
