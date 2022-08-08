using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public Data data;

    [SerializeField] private TMP_Text dotsText;

    private void Start()
    {
        data = new Data();
    }

    private void Update()
    {
        dotsText.text = "Dots: " + data.dots;
    }

    public void AddDot()
    {
        data.dots += 1;
    }
}