using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public class UpgradesManager : MonoBehaviour
{
    public Controller controller;
    public Upgrades clickUpgrade;

    public BigDouble clickUpgradeBaseCost;
    public BigDouble clickUpgradeCostMultiplier;
    public string clickUpgradeName;

    public void StartUpgradeManager()
    {
        clickUpgradeName = "Dot(s) per Click";
        clickUpgradeBaseCost = 10;
        clickUpgradeCostMultiplier = 1.5;
        UpdateClickUpgradeUi();
    }

    public void UpdateClickUpgradeUi()
    {
        clickUpgrade.LevelText.text = controller.data.clickUpgradeLevel.ToString();
        clickUpgrade.CostText.text = "Cost: " + Cost().ToString("F2") + " dots";
        clickUpgrade.NameText.text = "+1 " + clickUpgradeName;
    }

    public BigDouble Cost() => clickUpgradeBaseCost * BreakInfinity.BigDouble.Pow(clickUpgradeCostMultiplier, controller.data.clickUpgradeLevel);

    public void BuyUpgrade()
    {
        if (controller.data.dots >= Cost())
        {
            controller.data.dots -= Cost();
            controller.data.clickUpgradeLevel += 1;
        }

        UpdateClickUpgradeUi();
    }
}
 