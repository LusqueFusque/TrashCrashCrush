using System;
using UnityEngine;
//equivalente a nosso youtube
public static class PlayerObserverManager
{
    public static event Action<int> OnMoedasChanged;

    public static void MoedasChanged(int valor)
    {
        
    }

    internal static void ChangedMoedas(int moedas)
    {
        throw new NotImplementedException();
    }
}
