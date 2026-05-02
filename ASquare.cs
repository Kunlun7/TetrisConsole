using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TetrisConsole
{
	class ASquare : AFigure
	{


		public ASquare(int x, int y) {

			Points[0] = new APoint(x, y);
			Points[1] = new APoint(x + 1, y);
			Points[2] = new APoint(x, y + 1);
			Points[3] = new APoint(x + 1, y + 1);
		}

		public override void Rotate()
		{
		}


	}
}
