﻿namespace SyncView;

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
        videoView = new LibVLCSharp.WinForms.VideoView();
        ((System.ComponentModel.ISupportInitialize)videoView).BeginInit();
        SuspendLayout();
        // 
        // videoView
        // 
        videoView.BackColor = Color.Black;
        videoView.Location = new Point(8, 7);
        videoView.Margin = new Padding(2, 2, 2, 2);
        videoView.MediaPlayer = null;
        videoView.Name = "videoView";
        videoView.Size = new Size(1200, 675);
        videoView.TabIndex = 0;
        videoView.Text = "videoView1";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1584, 861);
        Controls.Add(videoView);
        Margin = new Padding(2, 2, 2, 2);
        MaximumSize = new Size(1600, 900);
        MinimumSize = new Size(1600, 900);
        Name = "MainForm";
        Text = "SyncView";
        ((System.ComponentModel.ISupportInitialize)videoView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private LibVLCSharp.WinForms.VideoView videoView;
}