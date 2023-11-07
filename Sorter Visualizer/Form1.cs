namespace BubbleSort_Visualizer
{
    public partial class Form1 : Form
    {
        private int[] arrayToSort;
        private int currentIndex = 0;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        
        public Form1()
        {
            Text = "Sorter Visualizer";
            Size = new Size(800, 600);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            arrayToSort = GenerateRandomArray(50, 10, 500);

            // Use the class-level timer field, not create a new local timer variable.
            timer.Interval = 50;
            timer.Tick += TimerTick;

            Button startButton = new Button();
            startButton.Text = "Start";
            startButton.Location = new Point(10, 10);
            startButton.Click += StartButtonClick;

            Controls.Add(startButton);

            Visible = true;
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            currentIndex = 0;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (currentIndex < arrayToSort.Length - 1)
            {
                BubbleSortStep();
                Invalidate();
                currentIndex++;
            }
            else
            {
                timer.Stop();
            }
        }

        private void BubbleSortStep()
        {
            if (arrayToSort[currentIndex] > arrayToSort[currentIndex + 1])
            {
                int temp = arrayToSort[currentIndex];
                arrayToSort[currentIndex] = arrayToSort[currentIndex + 1];
                arrayToSort[currentIndex + 1] = temp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int barWidth = ClientSize.Width / arrayToSort.Length;
            int maxBarHeight = ClientSize.Height - 50;

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                int barHeight = (int)(((double)arrayToSort[i] / GetMaxValue(arrayToSort)) * maxBarHeight);
                int x = i * barWidth;
                int y = ClientSize.Height - barHeight - 30;
                e.Graphics.FillRectangle(Brushes.Blue, x, y, barWidth, barHeight);
            }
        }

        private int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(minValue, maxValue + 1);
            }
            return array;
        }

        private int GetMaxValue(int[] arr)
        {
            int max = int.MinValue;
            foreach (int value in arr)
            {
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }

        
    }
}
