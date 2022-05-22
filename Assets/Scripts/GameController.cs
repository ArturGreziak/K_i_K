using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameController : MonoBehaviour
{
    public int FieldSize;

    public GameObject FieldPrefab;

    public abstract void Initialize();

    public abstract void CreateField(int  size);
}
