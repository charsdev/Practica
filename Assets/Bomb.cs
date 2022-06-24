using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chars.Tools;

public class Bomb : MonoBehaviour
{
    public BlinkColor blinkColor;
    public GameObject explosion;
    public bool activate;
    LambdaTimer lambdaTimer;

    void Start()
    {
        lambdaTimer = new LambdaTimer(blinkColor.GetTotalTime());
    }

    void Update()
    {
        if (activate)
        {
            lambdaTimer.Delay(() =>
            {
                Instantiate(explosion, transform.position, Quaternion.identity, null);
                Destroy(gameObject);
            });
        
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (activate) return;

        activate = true;
        blinkColor?.Execute();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag != "Player" && lambdaTimer.finished)
            Destroy(collision.gameObject);
    }
}
