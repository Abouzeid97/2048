using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_Mini
{
    public class pics
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public int val;
        public Bitmap img;
    }

    public partial class Form1 : Form
    {
        List<pics> num = new List<pics>();
        List<pics> p = new List<pics>();
        Timer tt = new Timer();
        Bitmap off;
        int fkey;
        int fdiren;
        int score;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Load += new EventHandler(Form1_Load);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            tt.Tick += new EventHandler(tt_Tick);
            tt.Start();
        }

        void createscore()
        {
            
        }

        void createbck()
        {
            pics pnn = new pics();
            pnn.img = new Bitmap ("bk.png");
            pnn.x = 450;
            pnn.y = 0;
            pnn.w = pnn.img.Width;
            pnn.h = pnn.img.Height;
            p.Add(pnn);
            pnn = new pics();
            pnn.img = new Bitmap("Bottom UI.png");
            pnn.x = 450;
            pnn.y = 700;
            pnn.w = pnn.img.Width;
            pnn.h = pnn.img.Height;
            p.Add(pnn);
            pnn = new pics();
            pnn.img = new Bitmap("Top UI.png");
            pnn.x =450;
            pnn.y = 0;
            pnn.w = pnn.img.Width;
            pnn.h = pnn.img.Height;
            p.Add(pnn);
            int ax = 500;
            int ay = 280;
            for ( int r = 0 ; r < 4 ; r++ )
            {
                ax = 560;
                for (int c = 0; c < 4; c++)
                {
                    pnn = new pics();
                    pnn.img = new Bitmap("tbck.png");
                    pnn.x = ax;
                    pnn.y = ay;
                    pnn.w = 80;
                    pnn.h = 80;
                    p.Add(pnn);
                    ax += 90;
                }
                ay += 90;
            }
        }

        void begin()
        {
            Random RR = new Random();
            int []ax = {560, 650, 740, 830};
            int []ay = {280, 370, 460, 550};
            for (int i = 0; i < 2; i++)
            {
                pics pnn = new pics();
                pnn.val = 2;
                pnn.img = new Bitmap( pnn.val+".png");
                int r = RR.Next(4);
                int c = RR.Next(4);
                pnn.x = ax[c];
                pnn.y = ay[r];
                pnn.w = 80;
                pnn.h = 80;
                num.Add(pnn);

            }
            createscore();
        }

        void moveright()
        {
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].x == 740)
                {
                    fdiren = 0;
                    for (; ; )
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[i].y == num[k].y && num[k].x == 830)
                            {
                                fdiren = 1;
                                break;
                            }
                        }
                        if (num[i].x == 830 || fdiren == 1)
                        {
                            break;
                        }
                        num[i].x += 10;
                    }
                }
            }
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].x == 650)
                {
                    fdiren = 0;
                    for (; ; )
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[i].y == num[k].y && num[k].x == num[i].x + 90)
                            {
                                fdiren = 1;
                                break;
                            }
                        }
                        if (num[i].x == 830 || fdiren == 1)
                        {
                            break;
                        }
                        num[i].x += 10;
                    }
                }
            }
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].x == 560)
                {
                    fdiren = 0;
                    for (; ; )
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[i].y == num[k].y && num[k].x == num[i].x + 90)
                            {
                                fdiren = 1;
                                break;
                            }
                        }
                        if (num[i].x == 830 || fdiren == 1)
                        {
                            break;
                        }
                        num[i].x += 10;
                    }
                }
            }
        }

        void moveleft()
        {
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].x == 650)
                {
                    fdiren = 0;
                    for (;;)
                    {
                        for ( int k = 0 ; k < num.Count ; k++ )
                        {
                            if ( num[i].y == num[k].y && num[k].x == 560)
                            {
                                fdiren  = 1;
                                break;
                            }
                        }
                        if ( num[i].x == 560 || fdiren == 1 )
                        {
                            break;
                        }
                        num[i].x -= 10;
                    }
                }
            }
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].x == 740)
                {
                    fdiren = 0;
                    for (; ; )
                    {
                        for ( int k = 0 ; k < num.Count; k ++ )
                        {
                            if (num[i].y == num[k].y && num[k].x == num[i].x - 90)
                            {
                                fdiren = 1;
                                break;
                            }
                        }
                        if (num[i].x == 560 || fdiren == 1)
                        {
                            break;
                        }
                        num[i].x -= 10;
                    }
                }
            }
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].x == 830)
                {
                    fdiren = 0;
                    for (; ; )
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[i].y == num[k].y && num[k].x == num[i].x - 90)
                            {
                                fdiren = 1;
                                break;
                            }
                        }
                        if (num[i].x == 560 || fdiren == 1)
                        {
                            break;
                        }
                        num[i].x -= 10;
                    }
                }
            }
        }

        void movedown()
        {
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].y == 460)
                {
                    fdiren = 0;
                    for (;;)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[i].x == num[k].x && num[k].y == 550)
                            {
                                fdiren = 1;
                                break;
                            }
                        }
                        if (num[i].y == 550 || fdiren == 1)
                        {
                            break;
                        }
                        num[i].y += 10;
                    }
                }
            }
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].y == 370)
                {
                    fdiren = 0;
                    for (; ; )
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[i].x == num[k].x && num[k].y == num[i].y + 90)
                            {
                                fdiren = 1;
                                break;
                            }
                        }
                        if (fdiren == 1 || num[i].y == 550)
                        {
                            break;
                        }
                        num[i].y += 10;
                    }
                }
            }
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].y == 280)
                {
                    fdiren = 0;
                    for (; ; )
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[i].x == num[k].x && num[k].y == num[i].y + 90)
                            {
                                fdiren = 1;
                                break;
                            }
                        }
                        if (fdiren == 1 || num[i].y == 550)
                        {
                            break;
                        }
                        num[i].y += 10;
                    }
                }
            }
        }

        void moveup()
        {
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].y == 370)
                {
                    fdiren = 0;
                    for (; ; )
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[i].x == num[k].x && num[k].y == 280)
                            {
                                fdiren = 1;
                                break;
                            }
                        }
                        if (fdiren == 1 || num[i].y == 280)
                        {
                            break;
                        }
                        num[i].y -= 10;
                    }
                }
            }
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].y == 460)
                {
                    fdiren = 0;
                    for (; ; )
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[i].x == num[k].x && num[k].y == num[i].y - 90)
                            {
                                fdiren = 1;
                                break;
                            }
                        }
                        if (fdiren == 1 || num[i].y == 280)
                        {
                            break;
                        }
                        num[i].y -= 10;
                    }
                }

            }
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i].y == 550)
                {
                    fdiren = 0;
                    for (; ; )
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[i].x == num[k].x && num[k].y == num[i].y - 90)
                            {
                                fdiren = 1;
                                break;
                            }
                        }
                        if (fdiren == 1 || num[i].y == 280)
                        {
                            break;
                        }
                        num[i].y -= 10;
                    }
                }

            }

        }

        void createone()
        {
            int r;
            int c;
            int f = 0;
            int[] ax = { 560, 650, 740, 830 };
            int[] ay = { 280, 370, 460, 550 };
            Random RR = new Random();
            for (; ; )
            {
                r = RR.Next(4);
                c = RR.Next(4);
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].x == ax[r] && num[i].y == ay[c])
                    {
                        f = 1;
                        break;
                    }
                    f = 0;
                }
                if ( f == 0)
                {
                    break;
                }
            }
            if (f == 0)
            {
                pics pnn = new pics();
                pnn.x = ax[r];
                pnn.y = ay[c];
                pnn.w = 80;
                pnn.h = 80;
                pnn.val = 2;
                pnn.img = new Bitmap(pnn.val+".png");
                num.Add(pnn);
            }
        }

        void assemble()
        {
            if (fkey == 1)
            {
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].y == 280)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].y == num[i].y + 90 && num[i].x == num[k].x && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                moveup();
                            }
                        }
                    }
                }
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].y == 370)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].y == num[i].y + 90 && num[i].x == num[k].x && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                moveup();
                            }
                        }
                    }
                }
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].y == 460)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].y == num[i].y + 90 && num[i].x == num[k].x && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                moveup();
                            }
                        }
                    }
                }
            }
            if (fkey == 2)
            {
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].y == 550)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].y == num[i].y - 90 && num[i].x == num[k].x && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                movedown();
                            }
                        }
                    }
                }
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].y == 460)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].y == num[i].y - 90 && num[i].x == num[k].x && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                movedown();
                            }
                        }
                    }
                }
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].y == 370)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].y == num[i].y - 90 && num[i].x == num[k].x && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                movedown();
                            }
                        }
                    }
                }
            }
            if (fkey == 3)
            {
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].x == 560)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].x == num[i].x + 90 && num[i].y == num[k].y && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                moveleft();
                            }
                        }
                    }
                }
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].x == 650)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].x == num[i].x + 90 && num[i].y == num[k].y && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                moveleft();
                            }
                        }
                    }
                }
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].x == 740)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].x == num[i].x + 90 && num[i].y == num[k].y && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                moveleft();
                            }
                        }
                    }
                }
            }
            if (fkey == 4)
            {
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].x == 830)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].x == num[i].x - 90 && num[i].y == num[k].y && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                moveright();
                            }
                        }
                    }
                }
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].x == 740)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].x == num[i].x - 90 && num[i].y == num[k].y && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                moveright();
                            }
                        }
                    }
                }
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i].x == 650)
                    {
                        for (int k = 0; k < num.Count; k++)
                        {
                            if (num[k].x == num[i].x - 90 && num[i].y == num[k].y && num[i].val == num[k].val)
                            {
                                num[i].val *= 2;
                                num[i].img = new Bitmap(num[i].val + ".png");
                                num.RemoveAt(k);
                                if (i != 0)
                                {
                                    i--;
                                }
                                moveright();
                            }
                        }
                    }
                }
            }
        }     

        void tt_Tick(object sender, EventArgs e)
        {
            drawdubb(this.CreateGraphics());
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                movedown();
                fkey = 2;
                assemble();
                createone();
            }
            if (e.KeyCode == Keys.Up)
            {
                moveup();
                fkey = 1;
                assemble();
                createone();

            }
            if (e.KeyCode == Keys.Left)
            {
                moveleft();
                fkey = 3;
                assemble();
                createone();
                
            }
            if (e.KeyCode == Keys.Right)
            {
                moveright();
                fkey = 4;
                assemble();
                createone();                
            }
            
        }

        void Form1_Load(object sender, EventArgs e)
        {
            off = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            createbck();
            begin();
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawdubb(e.Graphics);
        }

        void drawdubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            drawscene(g2);
            g.DrawImage(off, 0, 0);
        }

        void drawscene(Graphics g)
        {
            for (int i = 0; i < p.Count; i++)
            {
                g.DrawImage(p[i].img, p[i].x, p[i].y, p[i].w, p[i].h);
            }
            for (int i = 0; i < num.Count; i++)
            {
                g.DrawImage(num[i].img, num[i].x, num[i].y, num[i].w, num[i].h);
            }
        }
    }
}
