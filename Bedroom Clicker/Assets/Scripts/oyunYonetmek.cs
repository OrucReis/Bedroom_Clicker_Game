using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyunYonetmek : MonoBehaviour
{
    public Text coinText;
    public float simdikiCoin = 0;
    public float tiklanmaGucu = 1;
    public float saniyeBasinaGelenCoin = 1;
    public float otomatikCoinOrani = 0f;

   

    //market

    //urun 1

    public int urun1Ucret;

    public Text urun1Text;
    public Text coinOrani1Text;
    public Text urun1FiyatText;
    public int coin1=0;
    public float coinOrani1=0;

    public int urun2Ucret;
    public Text urun2Text;
    public Text coinOrani2Text;
    public Text urun2FiyatText;
    public int coin2=0;
    public float coinOrani2=0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coin: " + (int)simdikiCoin;
        saniyeBasinaGelenCoin = otomatikCoinOrani * Time.deltaTime;
        simdikiCoin = simdikiCoin + saniyeBasinaGelenCoin;

        //Market
        urun1Text.text = "Komidin";
        urun2Text.text = "Perde";

        //Fiyat
        urun1FiyatText.text = urun1Ucret+" ay";
        urun2FiyatText.text = urun2Ucret+" ay";

        //panel
        coinOrani1Text.text = "saniye baþý " + coin1 + " " + coinOrani1 + "/s";
        coinOrani2Text.text = "saniye baþý " + coin2 + " " + coinOrani2 + "/s";
    }

    public void Tiklanma()
    {
        simdikiCoin += tiklanmaGucu;
    }

    public void urun1()
    {
        if (simdikiCoin >= urun1Ucret)
        {
            simdikiCoin -= urun1Ucret;
            coin1 += 1;
            coinOrani1 += 1;
            otomatikCoinOrani += 1;
            urun1Ucret += 10;
        }
    }

    public void urun2()
    {
        if (simdikiCoin >= urun2Ucret)
        {
            simdikiCoin -= urun2Ucret;
            coin2 += 3;
            coinOrani2 += 3;
            otomatikCoinOrani += 3;
            urun2Ucret += 20;
        }
    }
}
