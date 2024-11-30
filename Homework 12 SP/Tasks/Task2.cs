using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

public partial class RaceForm : Form
{
    private ProgressBar[] horses = new ProgressBar[5];
    private Random random = new Random();
    private Thread[] horseThreads = new Thread[5];

    public RaceForm()
    {
        InitializeComponent();
    }

    private void btnStartRace_Click(object sender, EventArgs e)
    {
        flowLayoutPanel.Controls.Clear();
        for (int i = 0; i < 5; i++)
        {
            horses[i] = new ProgressBar();
            horses[i].Width = 300;
            horses[i].Maximum = 100;
            flowLayoutPanel.Controls.Add(horses[i]);
        }

        for (int i = 0; i < 5; i++)
        {
            int horseIndex = i;
            horseThreads[i] = new Thread(() => StartRace(horseIndex));
            horseThreads[i].Start();
        }
    }

    private void StartRace(int horseIndex)
    {
        int progress = 0;

        while (progress < 100)
        {
            Thread.Sleep(random.Next(100, 300));
            progress += random.Next(1, 5);

            if (progress > 100)
                progress = 100;

            Invoke(new Action(() => horses[horseIndex].Value = progress));
        }

        Invoke(new Action(() =>
        {
            lblResults.Text += $"Horse {horseIndex + 1} finished!{Environment.NewLine}";
            CheckRaceFinished();
        }));
    }

    private void CheckRaceFinished()
    {
        if (horseThreads.All(t => !t.IsAlive))
        {
            MessageBox.Show("The race is over! Check the results.");
        }
    }
}
