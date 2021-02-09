﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBallDirection : MonoBehaviour
{

    //public BoxCollider playerTerritory;
    GameObject player;
    bool playerInTerritory;
    public GameObject Spiderball;
    SpiderBallOrbit bossenemy;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        bossenemy = Spiderball.GetComponent<SpiderBallOrbit>();
        playerInTerritory = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (playerInTerritory == true)
        {
            bossenemy.MoveSpiderBall();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInTerritory = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInTerritory = false;
        }
    }
}

