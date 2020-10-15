using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Enemy1sound : MonoBehaviour
{

    private PlayerSoundManager PSMan;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("MusicPiece 1").GetComponent<EnemyController>().tagged == true)
        {

            return;
        }
    }

}
