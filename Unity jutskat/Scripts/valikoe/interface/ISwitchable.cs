using System;
using UnityEngine;
public interface ISwitchable
{
    public bool IsActive { get; set; }
    public void Activate();
    public void Deactivate();
}