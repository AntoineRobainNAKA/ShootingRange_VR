using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCible : MonoBehaviour
{

    public Transform Player;
    public GameObject PrefabToSpawn;
    public float SpawnRate = 4f;
    public int MaxSpawn = 3;
    private float NextSpawn;
    private int Nr = 0;
    
    private int Nb;

    private int Nt;

    public bool Respawn;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > NextSpawn && Nr<MaxSpawn && Nt<20)
        {
            NextSpawn = Time.time + SpawnRate;
            GameObject GO = Instantiate(PrefabToSpawn,transform.position,Quaternion.identity) as GameObject;
            GO.name = "Cible";
            Nr++;
            Nt++;
        }

        if(Respawn)
        {
            Nb = 0;

            foreach(GameObject Enn in FindObjectsOfType(typeof(GameObject))as GameObject[])
            {
                if(Enn.name == "Cible")
                {
                    Nb++;
                }
            }

            if(Nb<MaxSpawn)
            {
                Nr = Nb;
            }
        }
    }
}
