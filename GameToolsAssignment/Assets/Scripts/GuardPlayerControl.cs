﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardPlayerControl : MonoBehaviour {
    [SerializeField] private Animator m_anim;
    [SerializeField] private MindControl m_cntrl;
    [SerializeField] private AudioSource m_gunSFX;
    
    //Player input
    public void Move(float turn, float forward)
    {
        print("Forward: " + forward);
        if (m_cntrl.m_controlledGuard = this.gameObject)
        {
                m_anim.SetFloat("Turn", turn);
                m_anim.SetFloat("Forward", forward);
            }
        else
        {

        }
        }
    //Gun firing while controlling
    private void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            if(MindControl.control || RampGuardMindControl.control)
            {
                m_gunSFX.Play();
                m_anim.SetBool("isFiring", true);
            }
        }
        else
        {
            m_gunSFX.Stop();
            m_anim.SetBool("isFiring", false);
        }
    }
}

