using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oda_Button : MonoBehaviour
{
    public GameObject perde;
    public GameObject komidin1;
    public GameObject komidin2;

    public void Komidin()
    {
        komidin1.gameObject.SetActive(true);
        komidin2.gameObject.SetActive(true);
    }

    public void Perde()
    {
        perde.gameObject.SetActive(true);
    }
}
