using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TetrisConsole
{
	abstract class AFigure
	{
		protected APoint[] Points = new APoint[4];

		public void Draw()
		{

			foreach (APoint p in Points)
			{

				p.Draw();
			}
		}

		public void Clear()
		{

			foreach (APoint p in Points)
			{

				p.Clear();
			}
		}

		public void Move(EDirection dir)
		{

			foreach (APoint p in Points) {

				p.Move(dir);
			}
		}
		public abstract void Rotate();

	}
}
