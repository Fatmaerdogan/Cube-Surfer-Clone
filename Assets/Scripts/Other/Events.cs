using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Events 
{
    public static Action GameFinish;
    public static Action<GameObject> BlockDecreased;
    public static Action<GameObject> BlockIncreased;
}
