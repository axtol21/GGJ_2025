using UnityEngine;

[CreateAssetMenu(fileName = "ToTheMoon", menuName = "Scriptable Objects/Upgrades/ToTheMoon")]
public class ToTheMoon : _Upgrade
{
    public override string GetDescription()
    {
        return "<size=80%>At the end of each round, have the option to double your money! (Or lose it all...)</size>";
    }
}
