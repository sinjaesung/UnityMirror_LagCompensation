using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Snapshot3D : Snapshot
{
   public double remoteTime { get; set; }
    public double localTime { get; set; }
    public Vector3 position;

    public Snapshot3D(double remoteTime,double localTime,Vector3 position)
    {
        Debug.Log("Snapshot3D>>" + remoteTime + "," + localTime + "," + position);
        this.remoteTime = remoteTime;
        this.localTime = localTime;
        this.position = position;
    }

    public static Snapshot3D Interpolate(Snapshot3D from, Snapshot3D to, double t)
    {
        Debug.Log("Snapshot3D Interpolate>>" + new Snapshot3D(
           0, 0,
           Vector3.LerpUnclamped(from.position, to.position, (float)t)));

        return
       new Snapshot3D(
           0, 0,
           Vector3.LerpUnclamped(from.position, to.position, (float)t));
    }
   
}
