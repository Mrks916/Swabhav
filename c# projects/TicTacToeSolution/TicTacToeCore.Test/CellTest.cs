using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeCore;

namespace TicTacToeCore.Test
{
    [TestClass]
    public class CellTest
    {
        Cell cell = new Cell();
        [TestMethod]
        public void Test_WhenCellCreatedInitiallyItShouldBeEmpty()
        {
            Assert.AreEqual(cell.GetMark, MarkType.EMPTY);
        }
        [TestMethod]
        public void Test_ShouldBeAbleToMarkCell()
        {
            cell.MarkCell(MarkType.O);
            Assert.AreEqual(cell.GetMark, MarkType.O);
        }
        [TestMethod]
        public void Test_IsCellAlreadyMarked()
        {
            cell.MarkCell(MarkType.X);
            try
            {
                cell.MarkCell(MarkType.O);
            }
            catch (Exception ex) { }            
        }
    }
}
