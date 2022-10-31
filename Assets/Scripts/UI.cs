using UnityEngine;
using UnityEngine.Events;

public class UI : MonoBehaviour
{
    public string time = "5"; // 5 - default value
    public string speed = "100"; // 100 - defaule value
    public string range = "5"; // 5 - default value

    public void TimeChange(string timeValue)
    {
        time = timeValue;
    }

    public void SpeedChange(string speedValue)
    {
        speed = speedValue;
    }

    public void RangeChange(string rangeValue)
    {
        range = rangeValue;
    }
}
