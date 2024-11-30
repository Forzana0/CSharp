using System;
using System.Threading;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

public partial class MainForm : Form
{
    private int numberOfBars;

    public MainForm()
    {
        InitializeComponent();
    }

    private void btnGenerateBars_Click(object sender, EventArgs e)
    {
        numberOfBars = (int)numBars.Value;
        flowLayoutPanel.Controls.Clear();

        for (int i = 0; i < numberOfBars; i++)
        {
            ProgressBar progressBar = new ProgressBar();
            progressBar.Width = 200;
            progressBar.Maximum = 100;
            flowLayoutPanel.Controls.Add(progressBar);

            Thread thread = new Thread(() => StartProgressBar(progressBar));
            thread.Start();
        }
    }

    private void StartProgressBar(ProgressBar progressBar)
    {
        Random random = new Random();
        int progress = 0;

        while (progress < 100)
        {
            Thread.Sleep(random.Next(100, 500));
            progress += random.Next(1, 5);
            if (progress > 100) progress = 100;
            Invoke(new Action(() => progressBar.Value = progress));
        }
    }
}