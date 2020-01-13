using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileSystem;

namespace GridSystem
{
    public interface IGridView
    {
        event EventHandler GridViewInitialize;
        ITileView CreateTileView(int gridRow, int gridColumn);
        void CreateGridViewContainer();
        void InitializeGridView(object sender, EventArgs e);
    }
}
