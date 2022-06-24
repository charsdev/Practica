using System;
using UnityEngine;

namespace Chars.Tools
{
    [System.Serializable]
    public class LambdaTimer
    {
        private float current;
        private float initial;
        public bool finished;

        public LambdaTimer(float initial = 1f)
        {
            this.initial = initial;
            this.current = this.initial;
        }

        public void Delay(Action action)
        {
            current -= Time.deltaTime;
            if (current <= 0)
            {
                action();
                finished = true;
                current = initial;
            }
        }
    }
}
