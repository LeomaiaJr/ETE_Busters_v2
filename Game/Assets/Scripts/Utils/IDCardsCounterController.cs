using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IDCardsCounterController : MonoBehaviour
{

    Text idCardsCounter;
    void Start()
    {
        idCardsCounter = GameObject.Find("Canvas/Text").GetComponent<Text>();
        idCardsCounter.text = "100";
    }

    public void UpdateIDCardsCounter(string amount)
    {
        idCardsCounter.text = amount;
    }
}
