using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text timeText;
    float time;

    void Update()
    {
        time += Time.deltaTime;
        timeText.text = "Time: " + time.ToString("0.0");
    }
}