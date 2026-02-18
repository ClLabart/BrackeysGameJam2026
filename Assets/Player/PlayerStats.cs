using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public styleSlots styleSlot;

    public static int dysphoria;
    public int startDysphoria = 100;

    public static int timeToReturn;
    public int startTimeToReturn = 1000;

    // Update is called once per frame
    void Start()
    {
        dysphoria = startDysphoria;
        timeToReturn = startTimeToReturn;
    }
}

public enum styleSlots { hair, top, bottom, makeup }