using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid 
{
    private readonly uint _rowCount;
    private readonly uint _columnCount;

    public uint RowCount => _rowCount;
    public uint ColumnCount => _columnCount;
    
    public Grid(Vector3 center, uint rowCount, uint columnCount, float cellSize)
    {
        _rowCount = rowCount;
        _columnCount = columnCount;
    }

    public Vector3 CellToWorld(Vector2Int cellPos)
    {
        return Vector3.zero;
    }
}
