using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraformSimCS
{
    //Cell holds seven layers of air and soil, and all the biological info for them
    class Cell
    {
        //color
        public int Count { get; set; } //cell number in row
        public List<Atmosphere> AirColumn { get; set; }
        public List<BaseSoil> SoilColumn { get; set; }
    }
    class Row
    {
        //each row, since  row = 0 and row = height cannot read off the top and bottom of the planet, respectively
        public List<Cell> Cells { get; set; }
        public Cell this[int y]
        {
            get
            {
                if(Cell.Count >= y)
                    throw new ArgumentOutOfRangeException("Arguement out of bounds");
                return Cells[y];
            }
            set
            {
                if (Cells.Count >= y)
                    throw new ArgumentOutOfRangeException("Arguement out of bounds");
                Cells[y] = value;
            }
        }
        public Row()
        {
            Cells = new List<Cell>();
        }
        public void addCell(Cell cell)
        {
            Cells.Add(cell);
        }
        public void InsertCell(int index, Cell cell, int ColumnCount)
        {
            if (index < 0 || index >= ColumnCount) throw new ArgumentOutOfRangeException("Invalid Index value: must be greater than zero and less than Column count");
            Cells.Insert(index, cell);
        }
    }
    class Grid
    {
        public List<Row> GridObj { set; get; }
        public Grid(int rows, int columns)
        {
            Setup(rows,columns);  
        }
        public Cell this[int x, int y]
        {
            get { if (GridObj.Count <= x || ColumnCount <= y) throw new ArgumentOutOfRangeException("Argument out of bound"); return GridObj[x].Cells[y]; }
            set { if (GridObj.Count <= x || ColumnCount <= y) throw new ArgumentOutOfRangeException("Argument out of bound"); GridObj[x].Cells[y] = value; }
        }
        /*From this point on, copied from Conway Demo*/
        public Row this[int x]
        {
            get { if (GridObj.Count <= x) throw new ArgumentOutOfRangeException("Argument out of bound"); return GridObj[x]; }
            set { if (GridObj.Count <= x) throw new ArgumentOutOfRangeException("Argument out of bound"); GridObj[x] = value; }
        }
        // Get number of rows in grid
        public int RowCount { get { return GridObj.Count; } }
        // Get or Set number of columns in grid
        public int ColumnCount { set; get; }

        // Re-initialize a grid with all dead cells
        public void ReInitialize()
        {
            Setup(RowCount, ColumnCount);
        }

        // Setup grid by using row and column count
        private void Setup(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0) throw new ArgumentOutOfRangeException("Row and Column size must be greater than zero");
            GridObj = new List<Row>();
            for (int i = 0; i < rows; i++)
            {
                Row row = new Row();
                for (int j = 0; j < columns; j++)
                {
                    Cell cell = new Cell();
                    row.addCell(cell);
                }
                GridObj.Add(row);
            }
            ColumnCount = columns;
        }

        // Toggle state of input grid cells from its current state; live to dead or vice-verca    
        //public void ToggleCell(int x, int y)
        public void UpdateCell(int x, int y)
        {
            if (GridObj.Count <= x || ColumnCount <= y) throw new ArgumentNullException("Cell doesn't have data for required indexes");
            //this[x, y].IsAlive = !this[x, y].IsAlive;
            //update the cell with info about soil, water, air, et al.  Provide bitmap color
        }

        // Inserts a new row in the grid at specified index
        public void InsertRow(int index, Row row)
        {
            if (index < 0 || index >= RowCount) throw new ArgumentOutOfRangeException("Invalid Index value: must be greater than or equal to zero and less than Row count");
            GridObj.Insert(index, row);
        }

        // Add a new row in grid at the end in row list
        public void AddRow(Row row)
        {
            GridObj.Add(row);
        }
    }
}
