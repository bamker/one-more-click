using UnityEngine;
using TMPro;
using BreakInfinity;

public class Controller : MonoBehaviour
{
    public UpgradesManager upgradesManager;
    public Data data;

    [SerializeField] private TMP_Text dotsText;
    [SerializeField] private TMP_Text dotsClickPowerText;

    public BigDouble ClickPower() => 1 + data.clickUpgradeLevel;

    private void Start()
    {
        data = new Data();
        upgradesManager.StartUpgradeManager();
    }

    private void Update()
    {
        dotsText.text = "Dots: " + data.dots;
        dotsClickPowerText.text = "+" + ClickPower() + " dot(s)";
    }

    public void AddDot()
    {
        data.dots += ClickPower();
    }
}