namespace CactusDetector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string? _datasetFolder;
        private string? _outputModelFile;
        private string? _modelFile;
        private string? _targetImage;
        private readonly CactusDetector _detector = new CactusDetector();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Images (*.JPG)|*.JPG";

            this.openFileDialog.Multiselect = false;
            this.openFileDialog.Title = "Select Image";

            DialogResult dr = this.openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                labelSelectedImage.Text = this.openFileDialog.FileName;
                _targetImage = this.openFileDialog.FileName;
                pictureBoxPreview.Image = Image.FromFile(this.openFileDialog.FileName);
            }
        }

        private void buttonSelectDataset_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                labelSelectedFolder.Text = fbd.SelectedPath;
                _datasetFolder = fbd.SelectedPath;
            }
        }

        private void buttonSelectOutputModel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pb Model|*.pb";
            sfd.Title = "Save a Model File";
            sfd.ShowDialog();

            if (!string.IsNullOrEmpty(sfd.FileName))
            {
                labelSelectedOuputModel.Text = sfd.FileName;
                _outputModelFile = sfd.FileName;
            }
        }

        private void labelSelectedModel_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_datasetFolder))
            {
                MessageBox.Show("Please select a dataset folder");
                return;
            }
            if (string.IsNullOrEmpty(_outputModelFile))
            {
                MessageBox.Show("Please select an output model file");
                return;
            }

            buttonBuild.Enabled = false;
            backgroundWorkerTrain.RunWorkerAsync();

        }

        private void backgroundWorkerTrain_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ReportTraining("Training started");
            _detector.Train(_datasetFolder, _outputModelFile, ReportTraining);
            buttonBuild.Invoke((MethodInvoker)delegate
            {
                buttonBuild.Enabled = true;
            });
            ReportTraining("Training finished");

        }

        private void ReportTraining(string message)
        {
            labelBuildProgress.Invoke((MethodInvoker)delegate
            {
                labelBuildProgress.Text = message;
            });
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_modelFile))
            {
                MessageBox.Show("Please select a model file");
                return;
            }
            if (string.IsNullOrEmpty(_targetImage))
            {
                MessageBox.Show("Please select a target image");
                return;
            }
            labelResult.Text = _detector.Check(_modelFile, _targetImage);
        }

        private void buttonSelectModel_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Model (*.pb)|*.pb";

            this.openFileDialog.Multiselect = false;
            this.openFileDialog.Title = "Select Model";

            DialogResult dr = this.openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                labelSelectedImage.Text = this.openFileDialog.FileName;
                _modelFile = this.openFileDialog.FileName;
            }
        }
    }
}