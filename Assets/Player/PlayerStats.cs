using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public styleSlots styleSlot;

    public static int dysphoria;

    public static int timeToReturn;
    public int startTimeToReturn = 1000;

    public static int ActiveCharac;

    void Start()
    {
        timeToReturn = startTimeToReturn;
    }
}

public enum styleSlots { hair, top, bottom, makeup }