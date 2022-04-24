using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPSystem : MonoBehaviour
{
    //XP system 
    public int level; // used in example as laps 
    public float curEXP; //curLapsProgress
    public float reqEXP; //reqLapProgress
    public float Xpamount;

    //stats
    public float health;
    public float defense;
    public float speed;
    public float attack;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InitialStats()
    {
        //setup our stats, level, curexp, reqexp, etc/

        health = 100f;
        defense = 200f;
        speed = 50f;
        attack = 5f;

        level = 0;
        curEXP = 0f;
        reqEXP = 100f;
        Xpamount = 2f;


    }



    public void Interaction(float earnedExp)
    {
        //this is called by button presses, should grant a diff amount of exp

       if(Input.GetKeyDown(KeyCode.P))
        {
            GainXP(attack);
        }



    }

    public void GainXP(float gain)
    {

        //gain exp, probably something to do with our curEXP

        curEXP += gain;
        Debug.Log("EXP Gained" + gain);
        Debug.Log("Current EXP is: " + curEXP);
        LevelUp();



    }

    public void LevelUp()
    {
        //increase our level 
        if (curEXP >= reqEXP)
        {


            level += 1;

        }
    }

    public void IncreaseStats()
    {
        //increase our various stats 

        reqEXP += (100 + (10 * level));

        health += (100 + (10 * (level ^ 2)));
        defense += (200 + (10 * (level ^ 2)));
        speed += (50 + (5 * (level ^ 2)));
        attack += (5 + (5 * (level ^ 2)));


        {
            if (health >= 20f)
            {

            }

            else
            {
                speed = 100f;
            }
        }

    }
}

