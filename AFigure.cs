using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TetrisConsole
{
	abstract class AFigure
	{
		const int pCount = 4;
		protected APoint[] Points = new APoint[pCount];

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

		//public void Move(EDirection dir)
		//{
		//	Clear();

		//	foreach (APoint p in Points) {

		//		p.Move(dir);
		//	}

		//	Draw();
		//}

		public void TryMove(EDirection dir)
		{
			APoint[] newpoints = GetPoints();
			Move(newpoints, dir);
			if (VerifyPosition(newpoints))
			{
				Clear();
				Points = newpoints;
				Draw();
			}

		}

		private bool VerifyPosition(APoint[] plist)
		{
			foreach (APoint p in plist)
			{
				if (p.x < 0 || p.y < 0 || p.x >= 40 || p.y >= 30) {
					return false;
				}
			}
			return true;
		}

		public void Move(APoint[] plist, EDirection dir)
		{
			foreach (APoint p in plist)
			{
				p.Move(dir);
			}
		}


		private APoint[] GetPoints()
		{
			APoint[] np = new APoint[pCount];
			for (int i = 0; i < pCount; i++)
			{
				np[i] = new APoint(Points[i]);
			}

			return np;
		}

		public abstract void Rotate();

	}
}
