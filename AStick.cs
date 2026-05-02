using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsole
{
	class AStick : AFigure
	{

		public AStick(int x, int y, char c)
		{

			Points[0] = new APoint(x, y, c);
			Points[1] = new APoint(x, y + 1, c);
			Points[2] = new APoint(x, y + 2, c);
			Points[3] = new APoint(x, y + 3, c);
		}

		public override void Rotate(APoint[] plist)
		{

			if (plist[0].x == plist[1].x)
			{
				SetHorizontal(plist);
			}
			else {
				SetVertical(plist);
			}
		}


		private void SetHorizontal(APoint[] plist)
		{
			for (int i = 0; i < plist.Length; i++)
			{
				plist[i].y = plist[0].y;
				plist[i].x = plist[0].x + i;
			}
		}

		private void SetVertical(APoint[] plist)
		{
			for (int i = 0; i < plist.Length; i++)
			{
				plist[i].x = plist[0].x;
				plist[i].y = plist[0].y + i;
			}
		}
	}
}
