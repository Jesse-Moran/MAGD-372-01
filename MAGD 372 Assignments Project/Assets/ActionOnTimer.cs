using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionOnTimer : MonoBehaviour {
    
    private Action timerCallBack;
    public float timer;

    public void SetTimer(float timer, Action timerCallback) {
        this.timer = timer;
        this.timerCallBack = timerCallback;
    }

    public void Update() {
        if (timer > 0f) {
            timer -= Time.deltaTime;

            if (IsTimerComplete()) {
                timerCallBack();
            }
        }
    }

    public bool IsTimerComplete() {
        return timer <= 0f;
    }
}
