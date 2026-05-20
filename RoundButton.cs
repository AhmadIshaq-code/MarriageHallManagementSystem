using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundButton : Button
{
    private int borderRadius = 30;

    public int BorderRadius
    {
        get { return borderRadius; }
        set { borderRadius = value; this.Invalidate(); }
    }

    public RoundButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.BackColor = Color.Blue;
        this.ForeColor = Color.White;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        GraphicsPath path = new GraphicsPath();

        path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
        path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
        path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
        path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);

        path.CloseAllFigures();
        this.Region = new Region(path);

        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
    }
}
