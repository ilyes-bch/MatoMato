﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GP;
using UnityEngine.SocialPlatforms.Impl;

namespace GP
{
    public class Enemy : MonoBehaviour
    {
        public int maxHp = 2;
        protected int hp;

        // Start is called before the first frame update
        void Start()
        {
        }
        // Update is called once per frame
        void Update()
        {
        }

        void dameged(int minus)
        {
            hp -= minus;
        }

        void OnCollisionEnter(Collision col)
        {
            if (col.gameObject.tag == "Bullet1")
            {
                dameged(1);
                Destroy(col.gameObject);
                GameObject scoreManager = GameObject.FindGameObjectWithTag("ScoreManager") ;
                scoreManager.GetComponent<ScoreManager>().addScore();
            }
        }

    }
}
