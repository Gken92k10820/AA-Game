using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highestState;
    ScoreKeeper sk;
    // Start is called before the first frame update
    void Start()
    {
        sk = FindObjectOfType<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        int hs = sk.GetHighest();
        highestState.text = "Highest Round: \n" + hs.ToString();
    }
}
