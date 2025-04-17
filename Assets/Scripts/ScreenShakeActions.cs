using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ScreenShakeActions : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        ShootAction.OnAnyShoot += ShootAction_OnAnyShoot;
    }

    private void ShootAction_OnAnyShoot(object sender, ShootAction.OnShootEventArgs e)
    {
        ScreenShake.Instance.Shake();
    }

}
