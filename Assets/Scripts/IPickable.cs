using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickableTarget
{
    bool IsBlocked { get; set; }
    void PickTarget();
}
