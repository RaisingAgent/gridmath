﻿using System.Linq;
using PonderingProgrammer.GridMath.Shapes;
using Xunit;

namespace PonderingProgrammer.GridMath.Tests
{
    public class GridFanTest
    {
        [Fact]
        public void TestEdge()
        {
            var f1 = new GridFan(new GridCoordinatePair(), 1, Grid8Direction.Top);
            var f2 = new GridFan(new GridCoordinatePair(), 2, Grid8Direction.Top);
            var f3 = new GridFan(new GridCoordinatePair(), 3, Grid8Direction.Top);
            Assert.Equal(1, f1.BoundingBox.Width);
            Assert.Equal(4, f1.Edge.Count());
            Assert.Empty(f1.Interior);
        }
    }
}