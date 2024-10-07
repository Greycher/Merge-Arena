using System;
using UnityEngine;

namespace Model
{
    public class Grid 
    {
        private readonly int _rowCount;
        private readonly int _columnCount;
        private readonly float _cellSize;
        private readonly Vector3 _origin;

        public Grid(Vector3 origin, int rowCount, int columnCount, float cellSize)
        {
            if (rowCount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        
            if (columnCount <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        
            _origin = origin;
            _rowCount = rowCount;
            _columnCount = columnCount;
            _cellSize = cellSize;
        }

        public Vector3 CellToWorld(Vector2Int cellPos)
        {
            if (cellPos.x >= _rowCount)
            {
                throw new ArgumentOutOfRangeException();
            }
        
            if (cellPos.y >= _columnCount)
            {
                throw new ArgumentOutOfRangeException();
            }
        
            var midX = _rowCount / 2f - 0.5f;
            var midY = _columnCount / 2f - 0.5f;
            return _origin + new Vector3(cellPos.x - midX, 0, midY - cellPos.y) * _cellSize;
        }

        public void PutAnEntityToCell(Vector2Int cellPos, Entity entity)
        {
            
        }

        public void GetEntityAtCell(Vector2Int cellPos, Entity entity)
        {
            
        }
    }
}
