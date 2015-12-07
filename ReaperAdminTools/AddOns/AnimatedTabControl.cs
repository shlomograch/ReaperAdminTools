using System.Windows.Forms;
using System.Drawing;

namespace AnimatedTabControl
{
    class AnimTabControl : TabControl
    {
        public int Speed = 5;
        private int OldIndex = 0;

        public AnimTabControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnDeselected(TabControlEventArgs e)
        {
            OldIndex = e.TabPageIndex;
        }

        protected override void OnSelected(TabControlEventArgs e)
        {
            if (OldIndex < e.TabPageIndex)
                DoAnimationScrollRight(TabPages[OldIndex], TabPages[e.TabPageIndex]);
            else
                DoAnimationScrollLeft(TabPages[OldIndex], TabPages[e.TabPageIndex]);
        }

        private void DoAnimationScrollLeft(Control FirstControl, Control SecondControl)
        {
            Graphics ControlGraphics = FirstControl.CreateGraphics();
            Bitmap FirstControlBitmap = new Bitmap(FirstControl.Width, FirstControl.Height);
            Bitmap SecondControlBitmap = new Bitmap(SecondControl.Width, SecondControl.Height);

            FirstControl.DrawToBitmap(FirstControlBitmap, new Rectangle(0, 0, FirstControl.Width, FirstControl.Height));
            SecondControl.DrawToBitmap(SecondControlBitmap, new Rectangle(0, 0, SecondControl.Width, SecondControl.Height));

            foreach (Control C in FirstControl.Controls)
                C.Hide();

            int Slide = FirstControl.Width - (FirstControl.Width % Speed);
            int I;

            for (I = 0; I <= Slide; I += Speed)
            {
                ControlGraphics.DrawImage(FirstControlBitmap, new Rectangle(I, 0, FirstControl.Width, FirstControl.Height));
                ControlGraphics.DrawImage(SecondControlBitmap, new Rectangle(I - SecondControl.Width, 0, SecondControl.Width, SecondControl.Height));
            }

            I = FirstControl.Width;
            ControlGraphics.DrawImage(FirstControlBitmap, new Rectangle(I, 0, FirstControl.Width, FirstControl.Height));
            ControlGraphics.DrawImage(SecondControlBitmap, new Rectangle(I - SecondControl.Width, 0, SecondControl.Width, SecondControl.Height));

            SelectedTab = (TabPage)SecondControl;

            foreach (Control C in FirstControl.Controls)
                C.Show();
        }

        private void DoAnimationScrollRight(Control FirstControl, Control SecondControl)
        {
            Graphics ControlGraphics = FirstControl.CreateGraphics();
            Bitmap FirstControlBitmap = new Bitmap(FirstControl.Width, FirstControl.Height);
            Bitmap SecondControlBitmap = new Bitmap(SecondControl.Width, SecondControl.Height);

            FirstControl.DrawToBitmap(FirstControlBitmap, new Rectangle(0, 0, FirstControl.Width, FirstControl.Height));
            SecondControl.DrawToBitmap(SecondControlBitmap, new Rectangle(0, 0, SecondControl.Width, SecondControl.Height));

            foreach (Control C in FirstControl.Controls)
                C.Hide();

            int Slide = FirstControl.Width - (FirstControl.Width % Speed);
            int I;

            for (I = 0; I >= -Slide; I -= Speed) // += -Speed
            {
                ControlGraphics.DrawImage(FirstControlBitmap, new Rectangle(I, 0, FirstControl.Width, FirstControl.Height));
                ControlGraphics.DrawImage(SecondControlBitmap, new Rectangle(I + SecondControl.Width, 0, SecondControl.Width, SecondControl.Height));
            }

            I = FirstControl.Width;
            ControlGraphics.DrawImage(FirstControlBitmap, new Rectangle(I, 0, FirstControl.Width, FirstControl.Height));
            ControlGraphics.DrawImage(SecondControlBitmap, new Rectangle(I + SecondControl.Width, 0, SecondControl.Width, SecondControl.Height));
            SelectedTab = (TabPage)SecondControl;

            foreach (Control C in FirstControl.Controls)
                C.Show();

        }
    }
}