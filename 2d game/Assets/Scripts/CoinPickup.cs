﻿using System.Collections;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

    public int pointsToAdd;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Rigidbody2D>() == null)
            return;

        ScoreManager.AddPoints(pointsToAdd);

        Destroy(gameObject);

    }
}
