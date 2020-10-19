using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ActiveColorChangeable", menuName = "ScriptableObjects/ActiveColorChangeable", order = 1)]
public class ActiveColorChangeable : ScriptableObject
{
    public ColorChangeable active;
}
