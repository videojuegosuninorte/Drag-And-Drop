using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public static BoardManager Instance;
    [SerializeField] private Cell CellPrefab;
    private Grid grid;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        grid = new Grid(10, 10, 1, CellPrefab);

    }

    public List<Cell> getCells()
    {
        return grid.GetCells;
    }
}
