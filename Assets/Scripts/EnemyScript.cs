﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
	public int EnemyHealth = 10;

	void DeductPoints (int DamageAmount) {
		EnemyHealth -= DamageAmount;
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyHealth <= 0) {
			Destroy(gameObject);
		}
    }
}
