using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;

namespace Editor.Tests
{
    public class GridTest
    {
        [TestCase((uint)1,(uint)1, (uint)1, (uint)1)]
        [TestCase((uint)1,(uint)2, (uint)1, (uint)2)]
        public void WhenGridCreatedWithRowAndColumnCounts(uint rowCount, uint columnCount, 
            uint expectedColumnCount, uint expectedRowCount)
        {
            var grid = new Grid(Vector3.zero, rowCount, columnCount, 1);
            ThenItShouldReturnRightCounts(grid, expectedColumnCount, expectedRowCount);
        }
        
        private void ThenItShouldReturnRightCounts(Grid grid, uint expectedColumnCount, uint expectedRowCount)
        {
            Assert.AreEqual(grid.RowCount, expectedColumnCount);
            Assert.AreEqual(grid.ColumnCount, expectedRowCount);
        }
        
        [TestCase(1f, 0, 0, 0, 0, 0)]
        [TestCase(1f, 1, 3, 0, 0, 0)]
        public void WhenGridCreatedWithSpecificCellSize(float cellSize, int row, int col, 
            float expectedX, float  expectedY, float  expectedZ)
        {
            var grid = new Grid(Vector3.zero, 6, 8, 1);
            ThenItShouldReturnCorrectPos(grid, new Vector2Int(row, col), 
                new Vector3(expectedX, expectedY, expectedZ));
        }

        private void ThenItShouldReturnCorrectPos(Grid grid, Vector2Int cellPos, Vector3 expectedWorldPos)
        {
            Assert.AreEqual(grid.CellToWorld(cellPos), expectedWorldPos);
        }
    }
}