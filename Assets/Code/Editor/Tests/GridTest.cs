using System;
using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;
using Grid = Model.Grid;

namespace Tests
{
    public class GridTest
    {
        [Test]
        public void WhenGridCreatedWithZeroOrNegativeRowColumnCount()
        {
            ThenItShouldThrowArgumentOutOfRangeException(0, 1);
            ThenItShouldThrowArgumentOutOfRangeException(-1, 1);
            ThenItShouldThrowArgumentOutOfRangeException(1, 0);
            ThenItShouldThrowArgumentOutOfRangeException(1, -1);
            ThenItShouldThrowArgumentOutOfRangeException(-1, -1);
            ThenItShouldThrowArgumentOutOfRangeException(-99, 99);
            ThenItShouldThrowArgumentOutOfRangeException(-99, -99);
        }
        
        private void ThenItShouldThrowArgumentOutOfRangeException(int rowCount, int columnCount)
        {
            AssertExtensions.Throws<ArgumentOutOfRangeException>(() => new Grid(Vector3.zero, rowCount, columnCount, 1));
        }

        [TestCase(0, 0, 0, 3, 3, 1f, 1, 2, 0, 0, -1)]
        [TestCase(0, 0, 0, 3, 3, 1f, 0, 2, -1, 0, -1)]
        [TestCase(0, 0, 0, 3, 3, 1.5f, 0, 2, -1.5f, 0, -1.5f)]
        [TestCase(0, 0, 0, 4, 3, 1f, 0, 2, -1.5f, 0, -1)]
        [TestCase(0, 0, 0, 4, 3, 1.5f, 1, 2, -0.75f, 0, -1.5f)]
        [TestCase(0, 0, 0, 3, 4, 1.5f, 1, 2, 0f, 0, -0.75f)]
        [TestCase(0, 0, 0, 3, 4, 1.5f, 2, 1, 1.5f, 0, 0.75f)]
        [TestCase(1, 1, 2, 3, 3, 1f, 1, 2, 1, 1, 1)]
        public void WhenWorldPosAskedForACellPos(float originX, float originY, float originZ,
            int rowCount, int columnCount, float cellSize, int cellRowIndex, int cellColumnIndex,
            float expectedX, float expectedY, float expectedZ)
        {
            var origin = new Vector3(originX, originY, originZ);
            var grid = new Grid(origin, rowCount, columnCount, cellSize);
            var cellPos = new Vector2Int(cellRowIndex, cellColumnIndex);
            var expectedPos = new Vector3(expectedX, expectedY, expectedZ);
            ThenItShouldReturnCorrectWorldPos(grid, cellPos, expectedPos);
        }

        private void ThenItShouldReturnCorrectWorldPos(Grid grid, Vector2Int cellPos, Vector3 expectedWorldPos)
        {
            Assert.AreEqual(grid.CellToWorld(cellPos), expectedWorldPos);
        }
        
        [Test]
        public void WhenWorldPosAskedForOutOfRangeCellPos()
        {
            int rowCount = 1;
            int columnCount = 1;
            var grid = new Grid(Vector3.zero, rowCount, columnCount, 1);
            ThenItShouldThrowArgumentOutOfRangeException(grid, rowCount, columnCount);
        }

        private void ThenItShouldThrowArgumentOutOfRangeException(Grid grid, int rowCount, int columnCount)
        {
            AssertExtensions.Throws<ArgumentOutOfRangeException>(() => grid.CellToWorld(new Vector2Int(rowCount + 10, 0)));
            AssertExtensions.Throws<ArgumentOutOfRangeException>(() => grid.CellToWorld(new Vector2Int(0, columnCount + 10)));
        }
    
        [Test]
        public void WhenAnEntityPutOnACell()
        {
            var grid = new Grid(Vector3.zero, 5, 5, 1);
            ThenItShodulRetunrTheRightEntity();
        }

        private void ThenItShodulRetunrTheRightEntity()
        {
            throw new NotImplementedException();
        }
    }
}
