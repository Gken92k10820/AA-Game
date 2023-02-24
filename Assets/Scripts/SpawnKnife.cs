using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKnife : MonoBehaviour
{
    [SerializeField] GameObject knife;
    SpriteRenderer sr;
    [SerializeField] int numOfKnife = 1;

    public int GetKnifeNumber()
    {
        return numOfKnife;
    }

    GameController gc;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        gc = FindObjectOfType<GameController>();
    }
    void Update()
    {
        StartCoroutine("KnifeSpawn");
    }

    IEnumerator KnifeSpawn()
    {
        
        if (numOfKnife > 0)
        {
            sr.sprite = knife.GetComponent<SpriteRenderer>().sprite;

            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(knife, transform.position, transform.rotation);
                numOfKnife--;
            }
        }
        else
        {
            sr.sprite = null;
            yield return new WaitForSeconds(1f);
            gc.LoadNextGame();
        }
    }
}
