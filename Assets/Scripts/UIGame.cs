using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIGame : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI roundNumber;
    [SerializeField] TextMeshProUGUI knifeNumber;

    SpawnKnife sk;
    void Start()
    {
        sk = FindObjectOfType<SpawnKnife>();
        roundNumber.text = "Round " + SceneManager.GetActiveScene().buildIndex.ToString();
    }

    
    void Update()
    {
        knifeNumber.text = sk.GetKnifeNumber().ToString();
    }
}
