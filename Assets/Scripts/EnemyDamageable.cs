﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageable : MonoBehaviour, IDamageable
{
    [Header("Settings")]
    public GameObject bloodParticles;
    public int health;

    [Header("Debug")]
    [SerializeField] Transform m_Transform;

    // Start is called before the first frame update
    void Start()
    {
        m_Transform = this.transform;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        GameObject blood = Instantiate(bloodParticles, m_Transform.position, Quaternion.identity);
        Destroy(blood, 4);
    }
}
