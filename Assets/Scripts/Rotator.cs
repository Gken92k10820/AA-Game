using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] bool swap = false;

    [Header("Swap Time Random")]
    [SerializeField] float minTimeSwap = 2f;
    [SerializeField] float maxTimeSwap = 10f;

    float timeSwapDirection = 0f;
    
    void Start()
    {
        StartCoroutine("SwapDirection");
    }

    void Update()
    {
        Rotate();    
    }
    IEnumerator SwapDirection()
    {
        while (swap)
        {
            timeSwapDirection = Random.Range(minTimeSwap, maxTimeSwap);
            yield return new WaitForSeconds(timeSwapDirection);
            speed *= -1f;
        }
    }

    void Rotate()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
