﻿namespace Instrumentation2020
{
    partial class ComplexImpedanceAnalyser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.RandomLabel = new System.Windows.Forms.Label();
            this.PGAGainBox = new System.Windows.Forms.ComboBox();
            this.PGAGainLabel = new System.Windows.Forms.Label();
            this.SETPGAGAINButton = new System.Windows.Forms.Button();
            this.waveformbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.freqencySetButton = new System.Windows.Forms.Button();
            this.freqLabel = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.freqInput = new System.Windows.Forms.TextBox();
            this.Measure = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.timeoutBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portNameBox = new System.Windows.Forms.ComboBox();
            this.baudRateBox = new System.Windows.Forms.ComboBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.rtfTerminal = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbPortSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPortSettings.Controls.Add(this.RandomLabel);
            this.gbPortSettings.Controls.Add(this.PGAGainBox);
            this.gbPortSettings.Controls.Add(this.PGAGainLabel);
            this.gbPortSettings.Controls.Add(this.SETPGAGAINButton);
            this.gbPortSettings.Controls.Add(this.waveformbox);
            this.gbPortSettings.Controls.Add(this.label2);
            this.gbPortSettings.Controls.Add(this.freqencySetButton);
            this.gbPortSettings.Controls.Add(this.freqLabel);
            this.gbPortSettings.Controls.Add(this.ConnectBtn);
            this.gbPortSettings.Controls.Add(this.freqInput);
            this.gbPortSettings.Controls.Add(this.Measure);
            this.gbPortSettings.Controls.Add(this.resetbutton);
            this.gbPortSettings.Controls.Add(this.btnClear);
            this.gbPortSettings.Controls.Add(this.timeoutBox);
            this.gbPortSettings.Controls.Add(this.label1);
            this.gbPortSettings.Controls.Add(this.portNameBox);
            this.gbPortSettings.Controls.Add(this.baudRateBox);
            this.gbPortSettings.Controls.Add(this.lblComPort);
            this.gbPortSettings.Controls.Add(this.lblBaudRate);
            this.gbPortSettings.Location = new System.Drawing.Point(14, 299);
            this.gbPortSettings.Margin = new System.Windows.Forms.Padding(6);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Padding = new System.Windows.Forms.Padding(6);
            this.gbPortSettings.Size = new System.Drawing.Size(674, 332);
            this.gbPortSettings.TabIndex = 5;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "COM Serial Port Settings";
            // 
            // RandomLabel
            // 
            this.RandomLabel.AutoSize = true;
            this.RandomLabel.Location = new System.Drawing.Point(347, 282);
            this.RandomLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.RandomLabel.Name = "RandomLabel";
            this.RandomLabel.Size = new System.Drawing.Size(322, 25);
            this.RandomLabel.TabIndex = 21;
            this.RandomLabel.Text = " Hi Jack. Had some extra space.";
            // 
            // PGAGainBox
            // 
            this.PGAGainBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PGAGainBox.DropDownWidth = 67;
            this.PGAGainBox.Enabled = false;
            this.PGAGainBox.FormattingEnabled = true;
            this.PGAGainBox.ItemHeight = 25;
            this.PGAGainBox.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "5",
            "8",
            "10",
            "16",
            "32"});
            this.PGAGainBox.Location = new System.Drawing.Point(24, 279);
            this.PGAGainBox.Margin = new System.Windows.Forms.Padding(6);
            this.PGAGainBox.Name = "PGAGainBox";
            this.PGAGainBox.Size = new System.Drawing.Size(149, 33);
            this.PGAGainBox.TabIndex = 20;
            this.PGAGainBox.SelectedIndexChanged += new System.EventHandler(this.PGAGainBox_SelectedIndexChanged);
            // 
            // PGAGainLabel
            // 
            this.PGAGainLabel.AutoSize = true;
            this.PGAGainLabel.Location = new System.Drawing.Point(18, 252);
            this.PGAGainLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PGAGainLabel.Name = "PGAGainLabel";
            this.PGAGainLabel.Size = new System.Drawing.Size(113, 25);
            this.PGAGainLabel.TabIndex = 19;
            this.PGAGainLabel.Text = "PGA Gain:";
            // 
            // SETPGAGAINButton
            // 
            this.SETPGAGAINButton.Enabled = false;
            this.SETPGAGAINButton.Location = new System.Drawing.Point(188, 279);
            this.SETPGAGAINButton.Margin = new System.Windows.Forms.Padding(4);
            this.SETPGAGAINButton.Name = "SETPGAGAINButton";
            this.SETPGAGAINButton.Size = new System.Drawing.Size(134, 38);
            this.SETPGAGAINButton.TabIndex = 19;
            this.SETPGAGAINButton.Text = "Set";
            this.SETPGAGAINButton.UseVisualStyleBackColor = true;
            this.SETPGAGAINButton.Click += new System.EventHandler(this.SETPGAGAINButton_Click);
            // 
            // waveformbox
            // 
            this.waveformbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.waveformbox.DropDownWidth = 67;
            this.waveformbox.FormattingEnabled = true;
            this.waveformbox.ItemHeight = 25;
            this.waveformbox.Items.AddRange(new object[] {
            "Sine wave",
            "Square wave",
            "Triangle wave"});
            this.waveformbox.Location = new System.Drawing.Point(324, 142);
            this.waveformbox.Margin = new System.Windows.Forms.Padding(6);
            this.waveformbox.Name = "waveformbox";
            this.waveformbox.Size = new System.Drawing.Size(184, 33);
            this.waveformbox.TabIndex = 18;
            this.waveformbox.SelectedIndexChanged += new System.EventHandler(this.waveformbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Waveform:";
            // 
            // freqencySetButton
            // 
            this.freqencySetButton.Location = new System.Drawing.Point(528, 142);
            this.freqencySetButton.Margin = new System.Windows.Forms.Padding(4);
            this.freqencySetButton.Name = "freqencySetButton";
            this.freqencySetButton.Size = new System.Drawing.Size(134, 38);
            this.freqencySetButton.TabIndex = 16;
            this.freqencySetButton.Text = "Set";
            this.freqencySetButton.UseVisualStyleBackColor = true;
            this.freqencySetButton.Click += new System.EventHandler(this.freqencySetButton_Click);
            // 
            // freqLabel
            // 
            this.freqLabel.AutoSize = true;
            this.freqLabel.Location = new System.Drawing.Point(24, 115);
            this.freqLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.freqLabel.Name = "freqLabel";
            this.freqLabel.Size = new System.Drawing.Size(166, 25);
            this.freqLabel.TabIndex = 13;
            this.freqLabel.Text = "Frequency (Hz):";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(176, 63);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(146, 40);
            this.ConnectBtn.TabIndex = 14;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // freqInput
            // 
            this.freqInput.Location = new System.Drawing.Point(26, 142);
            this.freqInput.Margin = new System.Windows.Forms.Padding(4);
            this.freqInput.Name = "freqInput";
            this.freqInput.Size = new System.Drawing.Size(276, 31);
            this.freqInput.TabIndex = 15;
            this.freqInput.TextChanged += new System.EventHandler(this.freqInput_TextChanged);
            // 
            // Measure
            // 
            this.Measure.Enabled = false;
            this.Measure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Measure.Location = new System.Drawing.Point(24, 200);
            this.Measure.Margin = new System.Windows.Forms.Padding(6);
            this.Measure.Name = "Measure";
            this.Measure.Size = new System.Drawing.Size(298, 44);
            this.Measure.TabIndex = 12;
            this.Measure.Text = "&Measure";
            this.Measure.UseVisualStyleBackColor = true;
            this.Measure.Click += new System.EventHandler(this.Measure_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(352, 200);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(6);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(144, 44);
            this.resetbutton.TabIndex = 13;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(528, 200);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 44);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "&Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // timeoutBox
            // 
            this.timeoutBox.DropDownWidth = 67;
            this.timeoutBox.FormattingEnabled = true;
            this.timeoutBox.ItemHeight = 25;
            this.timeoutBox.Items.AddRange(new object[] {
            "1000",
            "2000",
            "5000",
            "7000",
            "10000"});
            this.timeoutBox.Location = new System.Drawing.Point(360, 63);
            this.timeoutBox.Margin = new System.Windows.Forms.Padding(6);
            this.timeoutBox.Name = "timeoutBox";
            this.timeoutBox.Size = new System.Drawing.Size(134, 33);
            this.timeoutBox.TabIndex = 5;
            this.timeoutBox.SelectedIndexChanged += new System.EventHandler(this.timeoutBox_SelectedIndexChanged);
            this.timeoutBox.TextUpdate += new System.EventHandler(this.timeoutBox_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Timeout (ms):";
            // 
            // portNameBox
            // 
            this.portNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portNameBox.FormattingEnabled = true;
            this.portNameBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.portNameBox.Location = new System.Drawing.Point(26, 63);
            this.portNameBox.Margin = new System.Windows.Forms.Padding(6);
            this.portNameBox.Name = "portNameBox";
            this.portNameBox.Size = new System.Drawing.Size(130, 33);
            this.portNameBox.TabIndex = 1;
            this.portNameBox.SelectedIndexChanged += new System.EventHandler(this.cmbPortName_SelectedIndexChanged);
            // 
            // baudRateBox
            // 
            this.baudRateBox.DropDownWidth = 67;
            this.baudRateBox.FormattingEnabled = true;
            this.baudRateBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRateBox.Location = new System.Drawing.Point(528, 63);
            this.baudRateBox.Margin = new System.Windows.Forms.Padding(6);
            this.baudRateBox.Name = "baudRateBox";
            this.baudRateBox.Size = new System.Drawing.Size(134, 33);
            this.baudRateBox.TabIndex = 3;
            this.baudRateBox.SelectedIndexChanged += new System.EventHandler(this.cmbBaudRate_SelectedIndexChanged);
            this.baudRateBox.TextUpdate += new System.EventHandler(this.cmbBaudRate_TextUpdate);
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(24, 33);
            this.lblComPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(112, 25);
            this.lblComPort.TabIndex = 0;
            this.lblComPort.Text = "COM Port:";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(524, 35);
            this.lblBaudRate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(119, 25);
            this.lblBaudRate.TabIndex = 2;
            this.lblBaudRate.Text = "Baud Rate:";
            // 
            // rtfTerminal
            // 
            this.rtfTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfTerminal.Location = new System.Drawing.Point(14, 4);
            this.rtfTerminal.Margin = new System.Windows.Forms.Padding(6);
            this.rtfTerminal.Name = "rtfTerminal";
            this.rtfTerminal.Size = new System.Drawing.Size(672, 283);
            this.rtfTerminal.TabIndex = 11;
            this.rtfTerminal.Text = "";
            this.rtfTerminal.TextChanged += new System.EventHandler(this.rtfTerminal_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ComplexImpedanceAnalyser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 646);
            this.Controls.Add(this.rtfTerminal);
            this.Controls.Add(this.gbPortSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ComplexImpedanceAnalyser";
            this.Text = "Complex Impedance Analyser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbPortSettings;
        private System.Windows.Forms.ComboBox portNameBox;
        private System.Windows.Forms.ComboBox baudRateBox;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtfTerminal;
        private System.Windows.Forms.Button Measure;
        private System.Windows.Forms.ComboBox timeoutBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.TextBox freqInput;
        private System.Windows.Forms.Button freqencySetButton;
        private System.Windows.Forms.Label freqLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox waveformbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.ComboBox PGAGainBox;
        private System.Windows.Forms.Label PGAGainLabel;
        private System.Windows.Forms.Button SETPGAGAINButton;
        private System.Windows.Forms.Label RandomLabel;
    }
}

