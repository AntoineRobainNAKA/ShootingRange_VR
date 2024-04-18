using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeSpawnCible : MonoBehaviour
{
    public GameObject FinChemin;
    public GameObject Mort;
    public GameObject Cible;
    public int Scoredetruit;

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "cibleEnd")
        {
            Destroy(Cible);
        }
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(Cible);
            Scoredetruit = Scoredetruit + 10;
        }
    }

}
