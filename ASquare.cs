using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TetrisConsole
{
	class ASquare : AFigure
	{


		public ASquare(int x, int y, char c) {

			Points[0] = new APoint(x, y, c);
			Points[1] = new APoint(x + 1, y, c);
			Points[2] = new APoint(x, y + 1, c);
			Points[3] = new APoint(x + 1, y + 1, c);
		}

		public override void Rotate()
		{
		}


	}
}
