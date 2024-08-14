using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Capture2D : Capture
{
    public double timestamp { get; set; }
    public Vector2 position;
    public Vector2 size;

    public Capture2D(double timestamp,Vector2 position,Vector2 size)
    {
        Debug.Log("Capture2D >> Constructor" + timestamp + "," + position + "," + size);

        this.timestamp = timestamp;
        this.position = position;
        this.size = size;
    }

    public void DrawGizmo()
    {
        Debug.Log("Capture2D DrawGizmo" + position + "," + size);
        Gizmos.DrawWireCube(position, size);
    }
    
    public static Capture2D Interpolate(Capture2D from,Capture2D to,double t)
    {
        Debug.Log("Capture2D Interpolate>>" + new Capture2D(
                0, // interpolated snapshot is applied directly. don't need timestamps.
                Vector2.LerpUnclamped(from.position, to.position, (float)t),
                Vector2.LerpUnclamped(from.size, to.size, (float)t)
            ));

        return new Capture2D(
                0, // interpolated snapshot is applied directly. don't need timestamps.
                Vector2.LerpUnclamped(from.position, to.position, (float)t),
                Vector2.LerpUnclamped(from.size, to.size, (float)t)
            );
    }
}
