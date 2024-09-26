using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Market_Button : MonoBehaviour
{
    public GameObject market;
    public GameObject marketAcButton;


    public void marketAc()
    {
        market.gameObject.SetActive(true);
        marketAcButton.gameObject.SetActive(false);
    }
    public void marketKapat()
    {
        market.gameObject.SetActive(false);
        marketAcButton.gameObject.SetActive(true);
    }
}
