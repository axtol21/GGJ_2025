using System;
using UnityEngine;
using UnityEngine.UI;

public abstract class _Upgrade : ScriptableObject
{
    public string displayName;
    public Image displayIcon;
    public float baseCost;

    public virtual void OnBuyFromShop() { }

    public virtual void OnRoundComplete(int upgradeLevel) { }

    public virtual void OnPlayerAttack(int upgradeLevel) { }
}