using System;
using System.Drawing;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();

        Form window = new Form
        {
            Text = "🙂",
            Size = new Size(300, 300),
            StartPosition = FormStartPosition.CenterScreen,
            TopMost = true
        };

        Label smiley = new Label
        {
            Text = "🙂",
            Font = new Font("Segoe UI Emoji", 120),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };

        window.Controls.Add(smiley);

        Application.Run(window);
    }
}
