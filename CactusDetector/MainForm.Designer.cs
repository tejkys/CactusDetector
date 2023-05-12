namespace CactusDetector
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonSelectDataset = new Button();
            labelSelectedFolder = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelBuildProgress = new Label();
            label1 = new Label();
            buttonBuild = new Button();
            labelSelectedOuputModel = new Label();
            buttonSelectOutputModel = new Button();
            tabPage2 = new TabPage();
            splitContainer1 = new SplitContainer();
            buttonSelectImage = new Button();
            labelSelectedImage = new Label();
            buttonSelectModel = new Button();
            labelSelectedModel = new Label();
            groupBox1 = new GroupBox();
            pictureBoxPreview = new PictureBox();
            labelResult = new Label();
            label3 = new Label();
            buttonCheck = new Button();
            openFileDialog = new OpenFileDialog();
            backgroundWorkerTrain = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            SuspendLayout();
            // 
            // buttonSelectDataset
            // 
            buttonSelectDataset.Image = Properties.Resources.folder_open;
            buttonSelectDataset.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSelectDataset.Location = new Point(6, 6);
            buttonSelectDataset.Name = "buttonSelectDataset";
            buttonSelectDataset.Size = new Size(151, 26);
            buttonSelectDataset.TabIndex = 0;
            buttonSelectDataset.Text = "Select Dataset Folder";
            buttonSelectDataset.TextAlign = ContentAlignment.MiddleRight;
            buttonSelectDataset.UseVisualStyleBackColor = true;
            buttonSelectDataset.Click += buttonSelectDataset_Click;
            // 
            // labelSelectedFolder
            // 
            labelSelectedFolder.AutoSize = true;
            labelSelectedFolder.Location = new Point(6, 35);
            labelSelectedFolder.Name = "labelSelectedFolder";
            labelSelectedFolder.Size = new Size(85, 15);
            labelSelectedFolder.TabIndex = 1;
            labelSelectedFolder.Text = "Selected folder";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(436, 215);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelBuildProgress);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(buttonBuild);
            tabPage1.Controls.Add(labelSelectedOuputModel);
            tabPage1.Controls.Add(buttonSelectOutputModel);
            tabPage1.Controls.Add(labelSelectedFolder);
            tabPage1.Controls.Add(buttonSelectDataset);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(428, 187);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Train";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelBuildProgress
            // 
            labelBuildProgress.AutoSize = true;
            labelBuildProgress.Location = new Point(70, 113);
            labelBuildProgress.Name = "labelBuildProgress";
            labelBuildProgress.Size = new Size(16, 15);
            labelBuildProgress.TabIndex = 6;
            labelBuildProgress.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 113);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Progress:";
            // 
            // buttonBuild
            // 
            buttonBuild.Image = Properties.Resources.hammer;
            buttonBuild.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBuild.Location = new Point(8, 141);
            buttonBuild.Name = "buttonBuild";
            buttonBuild.Size = new Size(73, 29);
            buttonBuild.TabIndex = 4;
            buttonBuild.Text = "Build";
            buttonBuild.TextAlign = ContentAlignment.MiddleRight;
            buttonBuild.UseVisualStyleBackColor = true;
            buttonBuild.Click += buttonBuild_Click;
            // 
            // labelSelectedOuputModel
            // 
            labelSelectedOuputModel.AutoSize = true;
            labelSelectedOuputModel.Location = new Point(6, 82);
            labelSelectedOuputModel.Name = "labelSelectedOuputModel";
            labelSelectedOuputModel.Size = new Size(146, 15);
            labelSelectedOuputModel.TabIndex = 3;
            labelSelectedOuputModel.Text = "Selected output model file";
            // 
            // buttonSelectOutputModel
            // 
            buttonSelectOutputModel.Image = Properties.Resources.folder_open;
            buttonSelectOutputModel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSelectOutputModel.Location = new Point(8, 53);
            buttonSelectOutputModel.Name = "buttonSelectOutputModel";
            buttonSelectOutputModel.Size = new Size(117, 26);
            buttonSelectOutputModel.TabIndex = 2;
            buttonSelectOutputModel.Text = "Output model";
            buttonSelectOutputModel.TextAlign = ContentAlignment.MiddleRight;
            buttonSelectOutputModel.UseVisualStyleBackColor = true;
            buttonSelectOutputModel.Click += buttonSelectOutputModel_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(428, 187);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Check use";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonSelectImage);
            splitContainer1.Panel1.Controls.Add(labelSelectedImage);
            splitContainer1.Panel1.Controls.Add(buttonSelectModel);
            splitContainer1.Panel1.Controls.Add(labelSelectedModel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(labelResult);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(buttonCheck);
            splitContainer1.Size = new Size(422, 181);
            splitContainer1.SplitterDistance = 190;
            splitContainer1.TabIndex = 6;
            // 
            // buttonSelectImage
            // 
            buttonSelectImage.Image = Properties.Resources.folder_open;
            buttonSelectImage.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSelectImage.Location = new Point(5, 50);
            buttonSelectImage.Name = "buttonSelectImage";
            buttonSelectImage.Size = new Size(145, 26);
            buttonSelectImage.TabIndex = 4;
            buttonSelectImage.Text = "Select Target Image";
            buttonSelectImage.TextAlign = ContentAlignment.MiddleRight;
            buttonSelectImage.UseVisualStyleBackColor = true;
            buttonSelectImage.Click += buttonSelectImage_Click;
            // 
            // labelSelectedImage
            // 
            labelSelectedImage.AutoSize = true;
            labelSelectedImage.Location = new Point(3, 79);
            labelSelectedImage.Name = "labelSelectedImage";
            labelSelectedImage.Size = new Size(87, 15);
            labelSelectedImage.TabIndex = 5;
            labelSelectedImage.Text = "Selected image";
            // 
            // buttonSelectModel
            // 
            buttonSelectModel.Image = Properties.Resources.folder_open;
            buttonSelectModel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSelectModel.Location = new Point(3, 3);
            buttonSelectModel.Name = "buttonSelectModel";
            buttonSelectModel.Size = new Size(132, 26);
            buttonSelectModel.TabIndex = 2;
            buttonSelectModel.Text = "Select Model File";
            buttonSelectModel.TextAlign = ContentAlignment.MiddleRight;
            buttonSelectModel.UseVisualStyleBackColor = true;
            buttonSelectModel.Click += buttonSelectModel_Click;
            // 
            // labelSelectedModel
            // 
            labelSelectedModel.AutoSize = true;
            labelSelectedModel.Location = new Point(3, 32);
            labelSelectedModel.Name = "labelSelectedModel";
            labelSelectedModel.Size = new Size(88, 15);
            labelSelectedModel.TabIndex = 3;
            labelSelectedModel.Text = "Selected model";
            labelSelectedModel.Click += labelSelectedModel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxPreview);
            groupBox1.Location = new Point(3, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Preview";
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Dock = DockStyle.Fill;
            pictureBoxPreview.Location = new Point(3, 19);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(214, 78);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.TabIndex = 0;
            pictureBoxPreview.TabStop = false;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(63, 110);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(16, 15);
            labelResult.TabIndex = 7;
            labelResult.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Result: ";
            // 
            // buttonCheck
            // 
            buttonCheck.Image = Properties.Resources.robot;
            buttonCheck.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCheck.Location = new Point(12, 137);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(109, 29);
            buttonCheck.TabIndex = 5;
            buttonCheck.Text = "Check via AI";
            buttonCheck.TextAlign = ContentAlignment.MiddleRight;
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // backgroundWorkerTrain
            // 
            backgroundWorkerTrain.DoWork += backgroundWorkerTrain_DoWork;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(436, 215);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CactusDetector";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelSelectedFolder;
        private Button buttonSelectDataset;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button buttonBuild;
        private Label labelSelectedOuputModel;
        private Button buttonSelectOutputModel;
        private TabPage tabPage2;
        private Label labelSelectedModel;
        private Button buttonSelectModel;
        private SplitContainer splitContainer1;
        private Label labelResult;
        private Label label3;
        private Button buttonCheck;
        private GroupBox groupBox1;
        private Button buttonSelectImage;
        private Label labelSelectedImage;
        private PictureBox pictureBoxPreview;
        private OpenFileDialog openFileDialog;
        private Label labelBuildProgress;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTrain;
    }
}