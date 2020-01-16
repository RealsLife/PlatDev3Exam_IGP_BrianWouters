using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileSystem
{ 
    public interface ITileView
    {
        int Row { get; set; }
        int Column {get;set;}
    }
}
