using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TetrisConsole
{
	class AFigure
	{
		protected APoint[] Points = new APoint[4];

		public void Draw()
		{

			foreach (APoint p in Points)
			{

				p.Draw();
			}
		}
	}
}
