using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour
{
    public Sprite[] sprites;
    public SpriteRenderer spriterenderer;

    public void Start()
    {
        var index = Random.Range(0, sprites.Length);
        spriterenderer.sprite = sprites[index];
    }
}
