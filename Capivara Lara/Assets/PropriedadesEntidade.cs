using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropriedadesEntidade : MonoBehaviour
{
    private static string TipoLixo = "Pl�stico";

    public static string GetTipoLixo() {
        return TipoLixo;
    }
}
