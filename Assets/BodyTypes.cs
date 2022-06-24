using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BodyTypes : MonoBehaviour
{
    public Sprite[] types = new Sprite[4];

    public SpriteRenderer currentPlayerModel;
    public Animator animator;

    public Animation[] animation = new Animation[4];
    public AnimationClip animationClip;

    public int index = 0;

    public int CurrentThreshold = 5;

    public void Update()
    {
        if (Global.Score >= CurrentThreshold)
        {
            index = index + 1 < types.Length ? index + 1 : 0;
            currentPlayerModel.sprite = types[index];

            CurrentThreshold += 5;
            animator?.SetInteger("Type", index);
        }
    }
}
