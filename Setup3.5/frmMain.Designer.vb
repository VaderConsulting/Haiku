<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblWindowsVersionLabel = New System.Windows.Forms.Label()
        Me.lblWindowsVersion = New System.Windows.Forms.Label()
        Me.lblOutlookVersionLabel = New System.Windows.Forms.Label()
        Me.lblOutlookVersion = New System.Windows.Forms.Label()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.btnConfigure = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.picCircles = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCircles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWindowsVersionLabel
        '
        Me.lblWindowsVersionLabel.AutoSize = True
        Me.lblWindowsVersionLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblWindowsVersionLabel.Location = New System.Drawing.Point(12, 9)
        Me.lblWindowsVersionLabel.Name = "lblWindowsVersionLabel"
        Me.lblWindowsVersionLabel.Size = New System.Drawing.Size(89, 13)
        Me.lblWindowsVersionLabel.TabIndex = 1
        Me.lblWindowsVersionLabel.Text = "Windows Version"
        '
        'lblWindowsVersion
        '
        Me.lblWindowsVersion.AutoSize = True
        Me.lblWindowsVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblWindowsVersion.Location = New System.Drawing.Point(12, 22)
        Me.lblWindowsVersion.Name = "lblWindowsVersion"
        Me.lblWindowsVersion.Size = New System.Drawing.Size(53, 13)
        Me.lblWindowsVersion.TabIndex = 2
        Me.lblWindowsVersion.Text = "Unknown"
        '
        'lblOutlookVersionLabel
        '
        Me.lblOutlookVersionLabel.AutoSize = True
        Me.lblOutlookVersionLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblOutlookVersionLabel.Location = New System.Drawing.Point(12, 35)
        Me.lblOutlookVersionLabel.Name = "lblOutlookVersionLabel"
        Me.lblOutlookVersionLabel.Size = New System.Drawing.Size(82, 13)
        Me.lblOutlookVersionLabel.TabIndex = 4
        Me.lblOutlookVersionLabel.Text = "Outlook Version"
        '
        'lblOutlookVersion
        '
        Me.lblOutlookVersion.AutoSize = True
        Me.lblOutlookVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblOutlookVersion.Location = New System.Drawing.Point(12, 48)
        Me.lblOutlookVersion.Name = "lblOutlookVersion"
        Me.lblOutlookVersion.Size = New System.Drawing.Size(53, 13)
        Me.lblOutlookVersion.TabIndex = 5
        Me.lblOutlookVersion.Text = "Unknown"
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        '
        'btnConfigure
        '
        Me.btnConfigure.Location = New System.Drawing.Point(15, 64)
        Me.btnConfigure.Name = "btnConfigure"
        Me.btnConfigure.Size = New System.Drawing.Size(75, 23)
        Me.btnConfigure.TabIndex = 9
        Me.btnConfigure.Text = "Configure"
        Me.btnConfigure.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(136, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(156, 16)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 10
        Me.picLogo.TabStop = False
        '
        'picCircles
        '
        Me.picCircles.BackColor = System.Drawing.Color.Transparent
        Me.picCircles.Image = Global.Setup3._5.My.Resources.Resources.The_Circles_transparent
        Me.picCircles.Location = New System.Drawing.Point(177, 85)
        Me.picCircles.Name = "picCircles"
        Me.picCircles.Size = New System.Drawing.Size(260, 240)
        Me.picCircles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCircles.TabIndex = 11
        Me.picCircles.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 202)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnConfigure)
        Me.Controls.Add(Me.lblOutlookVersion)
        Me.Controls.Add(Me.lblOutlookVersionLabel)
        Me.Controls.Add(Me.lblWindowsVersion)
        Me.Controls.Add(Me.lblWindowsVersionLabel)
        Me.Controls.Add(Me.picCircles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Haiku Candy"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCircles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWindowsVersionLabel As System.Windows.Forms.Label
    Friend WithEvents lblWindowsVersion As System.Windows.Forms.Label
    Friend WithEvents lblOutlookVersionLabel As System.Windows.Forms.Label
    Friend WithEvents lblOutlookVersion As System.Windows.Forms.Label
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents btnConfigure As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents picCircles As System.Windows.Forms.PictureBox

End Class
