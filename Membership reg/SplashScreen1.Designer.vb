<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DetailsLayoutPanel As System.Windows.Forms.TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        MainLayoutPanel = New TableLayoutPanel()
        DetailsLayoutPanel = New TableLayoutPanel()
        Version = New Label()
        Copyright = New Label()
        ApplicationTitle = New Label()
        MainLayoutPanel.SuspendLayout()
        DetailsLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainLayoutPanel
        ' 
        MainLayoutPanel.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        MainLayoutPanel.BackgroundImage = CType(resources.GetObject("MainLayoutPanel.BackgroundImage"), Image)
        MainLayoutPanel.BackgroundImageLayout = ImageLayout.Zoom
        MainLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        MainLayoutPanel.ColumnCount = 2
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 243.0F))
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100.0F))
        MainLayoutPanel.Controls.Add(DetailsLayoutPanel, 1, 1)
        MainLayoutPanel.Controls.Add(ApplicationTitle, 1, 0)
        MainLayoutPanel.Cursor = Cursors.AppStarting
        MainLayoutPanel.Dock = DockStyle.Left
        MainLayoutPanel.Location = New Point(0, 0)
        MainLayoutPanel.Name = "MainLayoutPanel"
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 218.0F))
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 38.0F))
        MainLayoutPanel.Size = New Size(496, 303)
        MainLayoutPanel.TabIndex = 0
        ' 
        ' DetailsLayoutPanel
        ' 
        DetailsLayoutPanel.Anchor = AnchorStyles.None
        DetailsLayoutPanel.BackColor = Color.Transparent
        DetailsLayoutPanel.ColumnCount = 1
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142.0F))
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142.0F))
        DetailsLayoutPanel.Controls.Add(Version, 0, 0)
        DetailsLayoutPanel.Controls.Add(Copyright, 0, 1)
        DetailsLayoutPanel.Location = New Point(248, 223)
        DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.0F))
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33.0F))
        DetailsLayoutPanel.Size = New Size(244, 76)
        DetailsLayoutPanel.TabIndex = 1
        ' 
        ' Version
        ' 
        Version.Anchor = AnchorStyles.None
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Version.Location = New Point(3, 9)
        Version.Name = "Version"
        Version.Size = New Size(238, 20)
        Version.TabIndex = 1
        Version.Text = "Version {0}.{1:00}"
        ' 
        ' Copyright
        ' 
        Copyright.Anchor = AnchorStyles.None
        Copyright.BackColor = Color.Transparent
        Copyright.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Copyright.Location = New Point(3, 38)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(238, 38)
        Copyright.TabIndex = 2
        Copyright.Text = "Copyright"
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.Anchor = AnchorStyles.None
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        ApplicationTitle.Location = New Point(248, 4)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(244, 212)
        ApplicationTitle.TabIndex = 0
        ApplicationTitle.Text = "Application Title"
        ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' SplashScreen1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(496, 303)
        ControlBox = False
        Controls.Add(MainLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplashScreen1"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        MainLayoutPanel.ResumeLayout(False)
        DetailsLayoutPanel.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

End Class
