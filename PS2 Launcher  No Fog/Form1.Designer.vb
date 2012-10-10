<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txt_Directory = New System.Windows.Forms.TextBox()
        Me.lbl_Directory = New System.Windows.Forms.Label()
        Me.btn_Browse = New System.Windows.Forms.Button()
        Me.btn_Launch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_Directory
        '
        Me.txt_Directory.Location = New System.Drawing.Point(12, 24)
        Me.txt_Directory.Name = "txt_Directory"
        Me.txt_Directory.Size = New System.Drawing.Size(458, 20)
        Me.txt_Directory.TabIndex = 0
        '
        'lbl_Directory
        '
        Me.lbl_Directory.AutoSize = True
        Me.lbl_Directory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Directory.Location = New System.Drawing.Point(12, 5)
        Me.lbl_Directory.Name = "lbl_Directory"
        Me.lbl_Directory.Size = New System.Drawing.Size(208, 16)
        Me.lbl_Directory.TabIndex = 1
        Me.lbl_Directory.Text = "PlanetSide 2 Game Directory"
        '
        'btn_Browse
        '
        Me.btn_Browse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Browse.Location = New System.Drawing.Point(476, 24)
        Me.btn_Browse.Name = "btn_Browse"
        Me.btn_Browse.Size = New System.Drawing.Size(63, 20)
        Me.btn_Browse.TabIndex = 2
        Me.btn_Browse.Text = "Browse"
        Me.btn_Browse.UseVisualStyleBackColor = True
        '
        'btn_Launch
        '
        Me.btn_Launch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Launch.Location = New System.Drawing.Point(12, 50)
        Me.btn_Launch.Name = "btn_Launch"
        Me.btn_Launch.Size = New System.Drawing.Size(527, 64)
        Me.btn_Launch.TabIndex = 3
        Me.btn_Launch.Text = "Patch and Launch"
        Me.btn_Launch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 121)
        Me.Controls.Add(Me.btn_Launch)
        Me.Controls.Add(Me.btn_Browse)
        Me.Controls.Add(Me.lbl_Directory)
        Me.Controls.Add(Me.txt_Directory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "PlanetSide 2 No Fog Launcher"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Directory As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Directory As System.Windows.Forms.Label
    Friend WithEvents btn_Browse As System.Windows.Forms.Button
    Friend WithEvents btn_Launch As System.Windows.Forms.Button

End Class
