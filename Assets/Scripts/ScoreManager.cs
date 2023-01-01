using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    private int coinScore;
    public Transform diamonds;
    public TextMeshProUGUI leverCleared;

    void Start()
    {
        if(instance == null)
          instance= this;
    }
    private void Update()
    {
        AllCollected();
    }
    public void ChangeCoinScore(int coinValue)
    {
        coinScore += coinValue;
        text.text = "X " + coinScore.ToString();
    }
    public void AllCollected()
    {
        if (diamonds.childCount == 0)
        {
            leverCleared.gameObject.SetActive(true);
        }
    }
}
