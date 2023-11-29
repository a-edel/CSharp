namespace Multiple_Sorts_Visualizer
{
    using System;
    using System.ComponentModel.Design.Serialization;
    using System.Diagnostics;
    using System.Windows.Forms;
    using static Multiple_Sorts_Visualizer.SortingForm;

    public partial class SortingForm : Form
    {
        private Sorter _sorter;
        private int[] arrayToSort;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private ISortingStrategy sortStrategy;

        private int currentStep = 0;
        private List<int[]> sortingSteps;

        public SortingForm()
        {
            InitializeComponent();
            Text = "Sorter Visualizer";
            Size = new Size(800, 600);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            arrayToSort = GenerateRandomArray(50, 10, 500);

            timer.Interval = 50;
            timer.Tick += TimerTick;

            RadioButton countingSortRadioButton = new RadioButton
            {
                Text = "Counting",
                Location = new System.Drawing.Point(10, 10)
            };

            RadioButton radixSortRadioButton = new RadioButton
            {
                Text = "Radix",
                Location = new System.Drawing.Point(10, 40)
            };

            RadioButton insertionSortRadioButton = new RadioButton
            {
                Text = "Insertion",
                Location = new System.Drawing.Point(10, 70)
            };

            RadioButton quickSortRadioButton = new RadioButton
            {
                Text = "Quick",
                Location = new System.Drawing.Point(10, 100)
            };

            Button startButton = new Button
            {
                Text = "Start",
                Location = new System.Drawing.Point(10, 130)
            };
            startButton.Click += startButtonClick;

            Controls.AddRange(new Control[] {
            countingSortRadioButton, radixSortRadioButton, insertionSortRadioButton,
            quickSortRadioButton, startButton
            });

            _sorter = new Sorter();

            sortingSteps = new List<int[]>();
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                int[] stepArray = new int[arrayToSort.Length];
                Array.Copy(arrayToSort, stepArray, arrayToSort.Length);
                sortingSteps.Add(stepArray);
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

        private void TimerTick(object sender, EventArgs e)
        {
            if (currentStep < sortingSteps.Count)
            {
                arrayToSort = sortingSteps[currentStep];
                Invalidate();
                currentStep++;
            }
            else
            {
                timer.Stop();
            }
        }


        private void startButtonClick(object sender, EventArgs e)
        {
            if (Controls.OfType<RadioButton>().Any(rb => rb.Checked))
            {
                RadioButton selectedRadioButton = Controls.OfType<RadioButton>().First(rb => rb.Checked);
                SortingAlgorithm selectedAlgorithm;
                switch (selectedRadioButton.Text)
                {
                    case "Counting":
                        sortStrategy = new CountingSort();
                        break;
                    case "Radix":
                        sortStrategy = new RadixSort();
                        break;
                    case "Insertion":
                        sortStrategy = new InsertionSort();
                        break;
                    case "Quick":
                        sortStrategy = new QuickSort();
                        break;
                }
                _sorter.SetSortingStrategy(sortStrategy);
                timer.Start();                 
            }
            else
            {
                MessageBox.Show("Please select a sorting algorithm.");
            }
        }


        private void SetSortingStrategy(ISortingStrategy sortingStrategy)
        {
            _sorter.SetSortingStrategy(sortingStrategy);
            _sorter.ExecuteSortStep(arrayToSort);
        }

        public interface ISortingStrategy
        {
            void Sort(int[] data);
        }

        public class CountingSort : ISortingStrategy
        {
            private List<int[]> sortingSteps;
            private int currentStep = 0;

            public void Sort(int[] data)
            {
                if (data == null || data.Length <= 1)
                    return;

                // Initialize sortingSteps with the initial state of the array
                sortingSteps = new List<int[]> { new int[data.Length] };
                Array.Copy(data, sortingSteps[0], data.Length);

                int minValue = data[0];
                int maxValue = data[0];

                for (int i = 1; i < data.Length; i++)
                {
                    if (data[i] < minValue)
                    {
                        minValue = data[i];
                    }
                    else if (data[i] > maxValue)
                    {
                        maxValue = data[i];
                    }
                }

                int range = maxValue - minValue + 1;
                int[] countArray = new int[range];

                for (int i = 0; i < data.Length; i++)
                {
                    countArray[data[i] - minValue]++;
                }

                for (int i = 1; i < countArray.Length; i++)
                {
                    countArray[i] += countArray[i - 1];
                }

                for (int i = data.Length - 1; i >= 0; i--)
                {
                    int index = data[i] - minValue;
                    countArray[index]--;
                    sortingSteps.Add(new int[data.Length]);
                    Array.Copy(data, sortingSteps[^1], data.Length);
                    sortingSteps[^1][countArray[index]] = data[i];
                }

                // Ensure the last step is added
                sortingSteps.Add(new int[data.Length]);
                Array.Copy(data, sortingSteps[^1], data.Length);
            }

            public void SortStep(int[] data, int step)
            {
                if (step >= 0 && step < sortingSteps.Count)
                {
                    Array.Copy(sortingSteps[step], data, data.Length);
                }
            }
        }


        public class RadixSort : ISortingStrategy
        {
            private List<int[]> sortingSteps;
            private int currentStep = 0;

            public void Sort(int[] data)
            {
                if (data == null || data.Length <= 1)
                    return;

                // Initialize sortingSteps with the initial state of the array
                sortingSteps = new List<int[]> { new int[data.Length] };
                Array.Copy(data, sortingSteps[0], data.Length);

                int maxValue = GetMaxValue(data);

                for (int exp = 1; maxValue / exp > 0; exp *= 10)
                {
                    CountSort(data, exp);
                    sortingSteps.Add(new int[data.Length]);
                    Array.Copy(data, sortingSteps[^1], data.Length);
                }
            }

            private void CountSort(int[] data, int exp)
            {
                int n = data.Length;
                int[] output = new int[n];
                int[] count = new int[10];

                for (int i = 0; i < n; i++)
                {
                    count[(data[i] / exp) % 10]++;
                }

                for (int i = 1; i < 10; i++)
                {
                    count[i] += count[i - 1];
                }

                for (int i = n - 1; i >= 0; i--)
                {
                    output[count[(data[i] / exp) % 10] - 1] = data[i];
                    count[(data[i] / exp) % 10]--;
                }

                Array.Copy(output, data, n);
            }

            public void SortStep(int[] data, int step)
            {
                if (step >= 0 && step < sortingSteps.Count)
                {
                    Array.Copy(sortingSteps[step], data, data.Length);
                }
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

        public class InsertionSort : ISortingStrategy
        {
            private List<int[]> sortingSteps;
            private int currentStep = 0;

            public void Sort(int[] data)
            {
                if (data == null || data.Length <= 1)
                    return;

                // Initialize sortingSteps with the initial state of the array
                sortingSteps = new List<int[]> { new int[data.Length] };
                Array.Copy(data, sortingSteps[0], data.Length);

                int n = data.Length;
                for (int i = 1; i < n; i++)
                {
                    int key = data[i];
                    int j = i - 1;

                    while (j >= 0 && data[j] > key)
                    {
                        data[j + 1] = data[j];
                        j = j - 1;
                    }

                    data[j + 1] = key;
                    sortingSteps.Add(new int[data.Length]);
                    Array.Copy(data, sortingSteps[^1], data.Length);
                }
            }

            public void SortStep(int[] data, int step)
            {
                if (step >= 0 && step < sortingSteps.Count)
                {
                    Array.Copy(sortingSteps[step], data, data.Length);
                }
            }
        }


        public class Sorter
        {
            private ISortingStrategy _sortingStrategy;

            public void SetSortingStrategy(ISortingStrategy sortingStrategy)
            {
                _sortingStrategy = sortingStrategy;
            }

            public void ExecuteSortStep(int[] data)
            {
                _sortingStrategy.Sort(data);
            }
        }

        public class QuickSort : ISortingStrategy
        {
            private List<int[]> sortingSteps;
            private int currentStep = 0;

            public void Sort(int[] data)
            {
                if (data == null || data.Length <= 1)
                    return;

                // Initialize sortingSteps with the initial state of the array
                sortingSteps = new List<int[]> { new int[data.Length] };
                Array.Copy(data, sortingSteps[0], data.Length);

                QuickSortAlgorithm(data, 0, data.Length - 1);
            }

            private void QuickSortAlgorithm(int[] data, int low, int high)
            {
                if (low < high)
                {
                    int pivotIndex = Partition(data, low, high);

                    QuickSortAlgorithm(data, low, pivotIndex - 1);
                    QuickSortAlgorithm(data, pivotIndex + 1, high);
                    sortingSteps.Add(new int[data.Length]);
                    Array.Copy(data, sortingSteps[^1], data.Length);
                }
            }

            private int Partition(int[] data, int low, int high)
            {
                int pivot = data[high];
                int i = low - 1;

                for (int j = low; j < high; j++)
                {
                    if (data[j] < pivot)
                    {
                        i++;
                        Swap(data, i, j);
                    }
                }

                Swap(data, i + 1, high);
                return i + 1;
            }

            private void Swap(int[] data, int i, int j)
            {
                int temp = data[i];
                data[i] = data[j];
                data[j] = temp;
            }

            public void SortStep(int[] data, int step)
            {
                if (step >= 0 && step < sortingSteps.Count)
                {
                    Array.Copy(sortingSteps[step], data, data.Length);
                }
            }
        }


        public enum SortingAlgorithm
        {
            CountingSort,
            RadixSort,
            InsertionSort,
            QuickSort
        }

    }
}