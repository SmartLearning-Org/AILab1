namespace AILab1
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            AlderBox = new NumericUpDown();
            IdeKnap = new Button();
            label2 = new Label();
            tabPage2 = new TabPage();
            flerePersonerHentIdeerKnap = new Button();
            rensButton = new Button();
            alderListBox = new ListBox();
            tilfojAlderKnap = new Button();
            tilfojAlderBox = new NumericUpDown();
            label1 = new Label();
            IdeLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            progressBar = new ProgressBar();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AlderBox).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tilfojAlderBox).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(44, 32);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(440, 365);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(AlderBox);
            tabPage1.Controls.Add(IdeKnap);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(432, 332);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "En person";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // AlderBox
            // 
            AlderBox.Location = new Point(37, 80);
            AlderBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AlderBox.Name = "AlderBox";
            AlderBox.Size = new Size(145, 27);
            AlderBox.TabIndex = 3;
            AlderBox.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // IdeKnap
            // 
            IdeKnap.Location = new Point(37, 121);
            IdeKnap.Name = "IdeKnap";
            IdeKnap.Size = new Size(94, 29);
            IdeKnap.TabIndex = 2;
            IdeKnap.Text = "Hent ideer";
            IdeKnap.UseVisualStyleBackColor = true;
            IdeKnap.Click += IdeKnap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 42);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 0;
            label2.Text = "Hvor gammel er du?";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(flerePersonerHentIdeerKnap);
            tabPage2.Controls.Add(rensButton);
            tabPage2.Controls.Add(alderListBox);
            tabPage2.Controls.Add(tilfojAlderKnap);
            tabPage2.Controls.Add(tilfojAlderBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(432, 332);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Flere personer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // flerePersonerHentIdeerKnap
            // 
            flerePersonerHentIdeerKnap.Location = new Point(284, 71);
            flerePersonerHentIdeerKnap.Name = "flerePersonerHentIdeerKnap";
            flerePersonerHentIdeerKnap.Size = new Size(94, 29);
            flerePersonerHentIdeerKnap.TabIndex = 4;
            flerePersonerHentIdeerKnap.Text = "Hent ideer";
            flerePersonerHentIdeerKnap.UseVisualStyleBackColor = true;
            flerePersonerHentIdeerKnap.Click += FlerePersonerHentIdeerKnap_Click;
            // 
            // rensButton
            // 
            rensButton.Location = new Point(34, 232);
            rensButton.Name = "rensButton";
            rensButton.Size = new Size(184, 29);
            rensButton.TabIndex = 3;
            rensButton.Text = "Tøm listen";
            rensButton.UseVisualStyleBackColor = true;
            rensButton.Click += RensButton_Click;
            // 
            // alderListBox
            // 
            alderListBox.FormattingEnabled = true;
            alderListBox.ItemHeight = 20;
            alderListBox.Location = new Point(33, 116);
            alderListBox.Name = "alderListBox";
            alderListBox.Size = new Size(185, 104);
            alderListBox.TabIndex = 2;
            // 
            // tilfojAlderKnap
            // 
            tilfojAlderKnap.Location = new Point(124, 74);
            tilfojAlderKnap.Name = "tilfojAlderKnap";
            tilfojAlderKnap.Size = new Size(94, 29);
            tilfojAlderKnap.TabIndex = 1;
            tilfojAlderKnap.Text = "Tilføj";
            tilfojAlderKnap.UseVisualStyleBackColor = true;
            tilfojAlderKnap.Click += TilfojAlderKnap_Click;
            // 
            // tilfojAlderBox
            // 
            tilfojAlderBox.Location = new Point(32, 73);
            tilfojAlderBox.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            tilfojAlderBox.Name = "tilfojAlderBox";
            tilfojAlderBox.Size = new Size(90, 27);
            tilfojAlderBox.TabIndex = 0;
            tilfojAlderBox.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(528, 62);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 2;
            label1.Text = "Forslag til hvad du kan lave:";
            // 
            // IdeLabel
            // 
            IdeLabel.Location = new Point(532, 91);
            IdeLabel.Name = "IdeLabel";
            IdeLabel.Size = new Size(188, 302);
            IdeLabel.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // progressBar
            // 
            progressBar.Location = new Point(50, 409);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(724, 29);
            progressBar.Step = 20;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.TabIndex = 4;
            progressBar.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar);
            Controls.Add(IdeLabel);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Hvad skal vi lave?";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AlderBox).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tilfojAlderBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label1;
        private Button IdeKnap;
        private Label IdeLabel;
        private NumericUpDown AlderBox;
        private ContextMenuStrip contextMenuStrip1;
        private Button tilfojAlderKnap;
        private NumericUpDown tilfojAlderBox;
        private Button flerePersonerHentIdeerKnap;
        private Button rensButton;
        private ListBox alderListBox;
        private ProgressBar progressBar;
    }
}