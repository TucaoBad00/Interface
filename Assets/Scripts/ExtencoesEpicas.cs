using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtencoesEpicas
{
    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }
}
