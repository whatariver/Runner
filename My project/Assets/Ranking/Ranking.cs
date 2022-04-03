using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using System.Linq;

public class Ranking : MonoBehaviour
{
    string myRanks;
    public int[] ranks = new int[3];
    public GameObject sb;
    public int myRank;
    public int a,b,c;


    void Update()
    {


        ranks[0] = (int)GameObject.Find("Girl").transform.position.z;
        ranks[1] = (int)GameObject.Find("Girl1").transform.position.z;
        ranks[2] = (int)GameObject.Find("Girl2").transform.position.z;
        ranks[3] = (int)GameObject.Find("Player").transform.position.z;

        
            if (ranks[0] > ranks[3]) a = 1;
            else a = 0;
            if (ranks[1] > ranks[3]) b = 1;
            else b = 0;
            if (ranks[2] > ranks[3]) c = 1;
            else c = 0;
        myRank = a + b + c;


        sb.GetComponent<UnityEngine.UI.Text>().text = (myRank+1).ToString();
    }



}
