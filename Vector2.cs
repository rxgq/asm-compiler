﻿namespace tgm;

internal class Vector2
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector2(int x, int y) 
    { 
        X = x; Y = y;
    }

    public static Vector2 Zero() => new(0, 0);
}
