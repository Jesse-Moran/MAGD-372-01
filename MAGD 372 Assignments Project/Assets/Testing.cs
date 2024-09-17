using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using CodeMonkey.Utils;

public class Testing : MonoBehaviour {

    [SerializeField] public ActionOnTimer actionOnTimer;

    public void Start(){
        actionOnTimer.SetTimer(1f, () => { Debug.Log("Timer compelte!"); });
    }
}
