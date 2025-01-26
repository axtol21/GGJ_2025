using System;
using UnityEngine;

public abstract class _Upgrade : ScriptableObject
{
    public string key;
    public int level;
    public string displayName;
    public Sprite displayIcon;
    public float baseCost;

    public virtual void OnBuyFromShop()
    {
        Player.Instance.AddUpgrade(this);
    }

    public virtual void OnRoundComplete(int upgradeLevel) { }

    public virtual void OnPlayerAttack(int upgradeLevel) { }

    public abstract string GetDescription();
}